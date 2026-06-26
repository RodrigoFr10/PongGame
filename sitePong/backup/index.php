<?php
session_start();

?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css">
    <link rel="stylesheet" href="style.css">
    <title>Login</title>
</head>
<body>
    <nav class="pageTop">
        <h1>Bem-vindo</h1>
    </nav>

    <div id="containerLogCad" class="containerLogCad">
        <form class="formLoginCad" action="login.php" method="post">
            <h2 class="titleLogin">Login</h2>
            <div class="input-group">
                <label for="nome">Nome</label>
                <input type="text" id="nome" name="nome" placeholder="Digite seu nome" required>
            </div>

            <div class="input-group">
                <label for="senha">Senha</label>
                <input type="password" id="senha" name="senha" placeholder="Digite sua senha" required>
            </div>

            <button class="submitLogCad" type="submit">
                <i class="fa-solid fa-right-to-bracket"></i>
                Entrar
            </button>
        </form>

        <form class="formLoginCad" action="register.php" method="post">
            <h2 class="titleLogin">Cadastro</h2>
            <div class="input-group">
                <label for="nome">Nome</label>
                <input type="text" id="nome" name="nome" placeholder="Digite seu nome" required>
            </div>

            <div class="input-group">
                <label for="senha">Senha</label>
                <input type="password" id="senha" name="senha" placeholder="Crie sua senha" required>
            </div>

            <button class="submitLogCad" type="submit">
                <i class="fa-solid fa-right-to-bracket"></i>
                Cadastrar
            </button>
        </form>
    </div>
</body>
</html>