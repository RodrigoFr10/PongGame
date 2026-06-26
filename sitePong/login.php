<?php

session_start();
require "db.php";

$username = $_POST["nome"] ?? "";
$password = $_POST["senha"] ?? "";

if ($username == "" || $password == "")
{
    die("Missing username or password");
}

$sql = "SELECT username, password
        FROM users
        WHERE username = ?";

$stmt = $conn->prepare($sql);
$stmt->bind_param("s", $username);
$stmt->execute();

$result = $stmt->get_result();

if ($result->num_rows == 0)
{
    die("User not found");
}

$row = $result->fetch_assoc();

$realUsername = $row["username"];
$hashedPassword = $row["password"];

if (password_verify($password, $hashedPassword))
{
    $_SESSION["username"] = $realUsername;

    header("Location: main.php");
    exit();
}
else
{
    echo "Wrong password";
}

?>