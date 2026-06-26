<?php

session_start();
require "db.php";

$postId =
$_POST["post_id"];

$reaction =
$_POST["reaction"];

$username =
$_SESSION["username"];

//checking reaction
$sql =
"SELECT reaction
 FROM post_reactions
 WHERE post_id=?
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
        "DELETE FROM post_reactions
         WHERE post_id=?
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
        "UPDATE post_reactions
         SET reaction=?
         WHERE post_id=?
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
    "INSERT INTO post_reactions
    (post_id, username, reaction)
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