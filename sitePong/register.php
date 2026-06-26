<?php

require "db.php";

$username = $_POST["nome"] ?? "";
$password = $_POST["senha"] ?? "";

if ($username == "" || $password == "")
{
    die("Missing username or password");
}

// Check if username already exists
$sql = "SELECT id FROM users WHERE username = ?";
$stmt = $conn->prepare($sql);
$stmt->bind_param("s", $username);
$stmt->execute();

$result = $stmt->get_result();

if ($result->num_rows > 0)
{
    die("Username already exists");
}

// Hash password exactly like the Unity version
$hashedPassword = password_hash($password, PASSWORD_DEFAULT);

$sql = "INSERT INTO users(username, password)
        VALUES(?, ?)";

$stmt = $conn->prepare($sql);
$stmt->bind_param("ss", $username, $hashedPassword);

if ($stmt->execute())
{
    header("Location: index.php");
    exit();
}
else
{
    echo "Registration failed";
}

?>