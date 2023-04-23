<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Bolos para sua festa de aniversário, casamento ou comemorações.">
    <link rel="icon" href="../img/icone.png" type="image/x-icon">
    <title>Dolcevitta</title>
    <link rel="stylesheet"
        href="https://unpkg.com/boxicons@latest/css/boxicons.min.css">

    <link rel="stylesheet" 
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">

    <link rel="stylesheet"
        href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"
        crossorigin="anonymous">

        <link rel="stylesheet" href="../css/style.css">
</head>

<body backgroundcolor="white" text="black">
 <header class="header">
        <a href="../index.php#home" class="logo"><i class="fas fa-birthday-cake"></i>Dolcevitta</a>
        <nav class="navbar" onclick="abrirMenu()">
            <a href="../index.php#home">home</a>
            <a href="../index.php#sobre">sobre</a>
            <a href="../index.php#produtos">produtos</a>
            <a href="../index.php#pedidos">fazer pedido</a>
            <?php 
            if(isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true && $_SESSION['username'] == 'admin') {
                echo '<a href="pedidos_admin.php">pedidos</a>';
            } elseif (isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true) {
                echo '<a href="pedidos.php">meus pedidos</a>';
            } else {
                echo '<a href="login.php">meus pedidos</a>';}
            
            ?>
        </nav>


        <div class="icons">
        <div id="menu-btn" class="bx bx-menu"></div>
    </header>

    <section class="secao-login">
        <container class="cont-login">
            <form autocomplete="off" class="form-usuario" name="frm_cadastro" method="post" autocomplete="off">
                <h4>Cadastro</h4>
                <input autocomplete="off" required="true" type="text" class="form-control" name="txt_usuario" placeholder="Nome de Usuário" id="nome">
                <input autocomplete="off" required="true" type="text" class="form-control" name="txt_email" placeholder="Email" id="email">
                <input autocomplete="off" required="true" type="password" class="form-control" name="txt_senha" placeholder="Senha" id="senha">
                
                <input id="botao" class="btn btn-primary mb1 bg-fuchsia" type="submit" name="btn_cadastrar" value="Cadastrar" onclick="document.frm_cadastro.action='cadastrar.php'">   
                <p class="texto-login">Já possui uma conta? <a class="link-login" href="login.php" name="btn_login" value="Entrar" onclick="document.frm_cadastro.action='login.php'">Faça login.</a></p>
            </form>
        </container>
    </section>
    <script src="../js/script.js"></script>
</body>

</html>