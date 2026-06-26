<?php
session_start();

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
            <tr>
                <td>NomeUsuario</td>
                <td>1</td>                    
            </tr>
        </table>
    </div>
    
    <div class="userPost">
        <form action="create_post.php" method="post">
            <div class="userArea">
                <img src="imagens/defaultUserImg.png"
                    class="userPicture">

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
        
        

        <div class="userPost">
            <div class="userArea">
                <img src="imagens/defaultUserImg.png" alt="user profile" class="userPicture">
                <h3 class="userName">Bob</h3>
            </div>
            <div class="userTxtArea">
                <p>Estou me divertindo muito hoje!</p>
                <div class="likeDislikeArea">
                    <i class="fa-regular fa-thumbs-up"><p class="numLikes">1</p></i> <!--deve virar fa-solid fa-thumbs-up se o usuario tiver clicado -->
                    <i class="fa-regular fa-thumbs-down"><p class="numDislikes">0</p></i>
                </div>
            </div>
            <div class="commentsArea">
                <div class="commentsAreaInput">
                    <input class="commentInput" placeholder="Comentar" type="text">
                    <button type="submit" class="commentSubmit">
                        <i class="fa fa-chevron-right"></i>
                    </button>
                </div>
                
                <div class="comment">
                    <div class="userArea">
                        <img src="imagens/defaultUserImg.png" alt="user profile" class="userPicture">
                        <h3 class="userName">Fred</h3>
                    </div>
                    <div class="userTxtArea">
                        <p>Eu tambémm</p>
                        <div class="likeDislikeArea">
                            <i class="fa-regular fa-thumbs-up"></i>
                            <i class="fa-regular fa-thumbs-down"></i>
                        </div>
                    </div>
                </div>
                <div class="comment">
                    <div class="userArea">
                        <img src="imagens/defaultUserImg.png" alt="user profile" class="userPicture">
                        <h3 class="userName">Frederiskoadweloooong</h3>
                    </div>
                    <div class="userTxtArea">
                        <p>Eu tambémm</p>
                        <div class="likeDislikeArea">
                            <i class="fa-regular fa-thumbs-up"></i>
                            <i class="fa-regular fa-thumbs-down"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="userPost">
            <div class="userArea">
                <img src="imagens/defaultUserImg.png" alt="user profile" class="userPicture">
                <h3 class="userName">Jack</h3>
            </div>
            <div class="userTxtArea">
                <p>Estou me divertindo muito hoje! Estou me divertindo muito hoje!</p>
                <div class="likeDislikeArea">
                    <i class="fa-regular fa-thumbs-up"></i>
                    <i class="fa-regular fa-thumbs-down"></i>
                </div>
            </div>
        </div>
    </div>
</body>
</html>