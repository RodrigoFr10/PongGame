<?php
session_start();
require "db.php";

if(!isset($_SESSION["username"]))
{
    header("Location: index.php");
    exit();
}
?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css">
    <link rel="stylesheet" href="style.css">
    <script type="text/javascript" src="pong.js"></script>
    <title>Home</title>
</head>
<body>
    <nav class="pageTop">
        <h1>Home - <?= $_SESSION["username"] ?></h1>
    </nav>
    <div class="scoreboardContainer">
        <button id="scoreboardBtn"class="scoreboardBtn" onclick="switchScoreboard()"><</button>
        <table class="scoreboard">
            <tr>
                <th>Nome</th>
                <th>Pontuação</th>
            </tr>
            <!-- <tr>
                <td>NomeUsuario</td>
                <td>1</td>                    
            </tr> -->
            <?php
                $sql = "
                SELECT
                    player_name,
                    MAX(score) AS best_score
                FROM leaderboard
                GROUP BY player_name
                ORDER BY best_score DESC
                LIMIT 10";

                $result = $conn->query($sql);

                while($row = $result->fetch_assoc())
                {
                ?>

                <tr>
                    <td>
                        <?= htmlspecialchars($row["player_name"]) ?>
                    </td>

                    <td>
                        <?= $row["best_score"] ?>
                    </td>
                </tr>

                <?php
                }
                ?>
        </table>
    </div>
    
    <div class="userPost">
        <form action="create_post.php" method="post">
            <div class="userArea">
                <img src="imagens/defaultUserImg.png" class="userPicture">
                <h3 class="userName">
                    <?= $_SESSION["username"] ?>
                </h3>
            </div>

            <div class="userTxtArea">

                <textarea
                    name="content"
                    rows="4"
                    style="width:100%; color:black;"
                    placeholder="Escreva o que tem em mente"
                    required></textarea>

                <br><br>

                <button class="commentSubmit">
                    Post
                </button>

            </div>

        </form>

    </div>
    <div id="threads" class="threads">
        <h2>Posts recentes</h2>
        
        <?php
            $sql = "SELECT *
                    FROM posts
                    ORDER BY created_at DESC";

            $result = $conn->query($sql);

            while($row = $result->fetch_assoc())
            {
                $likeSql = "
                    SELECT COUNT(*) AS total
                    FROM post_reactions
                    WHERE post_id = ?
                    AND reaction = 'like'";

                $likeStmt = $conn->prepare($likeSql);
                $likeStmt->bind_param("i", $row["id"]);
                $likeStmt->execute();

                $likes =
                $likeStmt->get_result()->fetch_assoc()["total"];

                $dislikeSql = "
                    SELECT COUNT(*) AS total
                    FROM post_reactions
                    WHERE post_id = ?
                    AND reaction = 'dislike'";

                $dislikeStmt = $conn->prepare($dislikeSql);
                $dislikeStmt->bind_param("i", $row["id"]);
                $dislikeStmt->execute();

                $dislikes =
                $dislikeStmt->get_result()->fetch_assoc()["total"];
            ?>

            <div class="userPost">

                <div class="userArea">
                    <img src="imagens/defaultUserImg.png"
                        class="userPicture">

                    <h3 class="userName">
                        <?= htmlspecialchars($row["author"]) ?>
                    </h3>
                </div>

                <div class="userTxtArea">

                    <p>
                        <?= htmlspecialchars($row["content"]) ?>
                    </p>
                    <div class="likeDislikeArea">

                        <form action="react.php" method="post" style="display:inline;">
                            <input type="hidden" name="post_id" value="<?= $row["id"] ?>">
                            <input type="hidden" name="reaction" value="like">

                            <button class="likeDislikeInput" type="submit">
                                <i class="fa-regular fa-thumbs-up"><p class="numLikes"><?= $likes ?></p></i> 
                            </button>
                        </form>

                        <form action="react.php" method="post" style="display:inline;">
                            <input type="hidden" name="post_id" value="<?= $row["id"] ?>">
                            <input type="hidden" name="reaction" value="dislike">

                            <button class="likeDislikeInput" type="submit">
                                <i class="fa-regular fa-thumbs-down"><p class="numLikes"><?= $dislikes ?></p></i> 
                            </button>
                        </form>
                    </div>
                </div>
                    <div class="commentsArea">

                        <div class="commentsAreaInput">

                            <form action="create_comment.php" method="post">

                                <input
                                    type="hidden"
                                    name="post_id"
                                    value="<?= $row["id"] ?>">

                                <input
                                    class="commentInput"
                                    type="text"
                                    name="content"
                                    placeholder="Comentar"
                                    required>

                                <button class="commentSubmit">
                                    >
                                </button>

                            </form>

                        </div>
                    <?php
                        $commentSql =
                        "SELECT *
                        FROM comments
                        WHERE post_id = ?
                        ORDER BY created_at ASC";

                        $commentStmt =
                        $conn->prepare($commentSql);

                        $commentStmt->bind_param(
                            "i",
                            $row["id"]
                        );

                        $commentStmt->execute();

                        $comments =
                        $commentStmt->get_result();

                        while($comment =
                            $comments->fetch_assoc())
                        {
                    ?>
                    <div class="comment">

                        <div class="userArea">

                            <img src="imagens/defaultUserImg.png" class="userPicture">
                            <h3 class="userName">
                                <?= htmlspecialchars(
                                        $comment["author"]
                                ) ?>
                            </h3>

                        </div>

                        <div class="userTxtArea">

                            <p>
                                <?= htmlspecialchars(
                                        $comment["content"]
                                ) ?>
                            </p>

                        </div>

                    </div>
                    <?php
                        }
                    ?>
                    </div>
                

            </div>
        
        <?php
            }
        ?>

        
    </div>
</body>
</html>