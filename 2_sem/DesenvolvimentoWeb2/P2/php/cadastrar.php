<?php
session_start();
include 'conexao.php';

$usuario = $_POST ["txt_usuario"];
$email = $_POST ["txt_email"];
$senha = $_POST ["txt_senha"];
$tel = $_POST ["txt_tel"];

$sql = mysql_query ("SELECT * FROM tb_usuarios WHERE email='$email'");

if (mysql_num_rows($sql) > 0) {
    ?>
    <!DOCTYPE html>
    <html>
    
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
    
    <body>
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
								<p>E-mail já está sendo usado. Tente novamente.</p>
                                <input id="botao" class="btn btn-primary mb1 bg-fuchsia" type="button" name="btn_voltar" value="Voltar" onclick="window.location.href='cadastro.php';">
						</container>
					</section>
					<script src="../js/script.js"></script>
		</body>
    
    </html>
<?php
    } else {
        $sql = mysql_query ("INSERT into tb_usuarios (nome,email,senha,tel)
                            values ('$usuario','$email','$senha','$tel')");
            
            $_SESSION['logged_in'] = true;
			$_SESSION['usermail'] = $email;
			$_SESSION['username'] = $usuario;

        if(isset($_SESSION['form_preench'])) {
            header("Location: ..\index.php#pedidos");
        } elseif ($usuario == "admin@admin" || $usuario == "admin") {
            header("Location: pedidos_admin.php");
        } else {
            header("Location: ..\index.php");
        }                 

    }
    ?>