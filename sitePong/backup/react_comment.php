<?php

session_start();
require "db.php";

$postId =
$_POST["comment_id"];

$reaction =
$_POST["reaction"];

$username =
$_SESSION["username"];

//checking reaction
$sql =
"SELECT reaction
 FROM comment_reactions
 WHERE comment_id=?
 AND username=?";

$stmt =
$conn->prepare($sql);

$stmt->bind_param(
    "is",
    $postId,
    $username
);

$stmt->execute();

$result =
$stmt->get_result();

//if already reacted
if($result->num_rows > 0)
{
    $row =
    $result->fetch_assoc();

    if($row["reaction"] == $reaction)
    {
        $sql =
        "DELETE FROM comment_reactions
         WHERE comment_id=?
         AND username=?";

        $stmt =
        $conn->prepare($sql);

        $stmt->bind_param(
            "is",
            $postId,
            $username
        );

        $stmt->execute();
    }
    else
    {
        $sql =
        "UPDATE comment_reactions
         SET reaction=?
         WHERE comment_id=?
         AND username=?";

        $stmt =
        $conn->prepare($sql);

        $stmt->bind_param(
            "sis",
            $reaction,
            $postId,
            $username
        );

        $stmt->execute();
    }
}

//if no reaction yet
else
{
    $sql =
    "INSERT INTO comment_reactions
    (comment_id, username, reaction)
    VALUES(?,?,?)";

    $stmt =
    $conn->prepare($sql);

    $stmt->bind_param(
        "iss",
        $postId,
        $username,
        $reaction
    );

    $stmt->execute();
}

header("Location: main.php");
exit();