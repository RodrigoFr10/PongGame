<?php

session_start();
require "db.php";

$content = $_POST["content"];
$author = $_SESSION["username"];

$sql = "INSERT INTO posts(author, content)
        VALUES(?, ?)";

$stmt = $conn->prepare($sql);
$stmt->bind_param("ss", $author, $content);

$stmt->execute();

header("Location: main.php");
exit();

?>