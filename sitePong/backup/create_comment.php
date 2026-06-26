<?php

session_start();
require "db.php";

$postId =
$_POST["post_id"] ?? 0;

$content =
$_POST["content"] ?? "";

$author =
$_SESSION["username"];

$sql =
"INSERT INTO comments
(post_id, author, content)
VALUES (?, ?, ?)";

$stmt =
$conn->prepare($sql);

$stmt->bind_param(
    "iss",
    $postId,
    $author,
    $content
);

$stmt->execute();

header("Location: main.php");
exit();

?>