<?php
session_start();
include 'conexao.php';
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

            <div class="icons">
			<?php
				if(isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true){
					echo 'Olá, '.$_SESSION['username'].'<div id="btn_logout_sub" class="bx bx-log-out-circle"></div>';
				} else {
					echo '<div id="btn_login_sub" class="bx bx-log-in-circle"></div>';
				}
		    ?>
            <div id="btn_carrinho_sub" class="bx bx-cart"></div>
		    <div id="menu-btn" class="bx bx-menu"></div>
            </div>
        </header>
    
        <section class="secao-login">
            <container class="cont-login">
            <form method="post" name="frm_att" action="">
        <label for="status_pedido">Novo status:</label>
        <select id="status_pedido" name="status_pedido">
            <option value="Realizado" <?php if($_GET['status_pdd'] == 'Realizado') echo 'selected'; ?>>Realizado</option>
            <option value="Preparando" <?php if($_GET['status_pdd'] == 'Preparando') echo 'selected'; ?>>Preparando</option>
            <option value="Pronto" <?php if($_GET['status_pdd'] == 'Pronto') echo 'selected'; ?>>Pronto</option>
            <option value="Finalizado" <?php if($_GET['status_pdd'] == 'Finalizado') echo 'selected'; ?>>Finalizado</option>
            <option value="Cancelado" <?php if($_GET['status_pdd'] == 'Cancelado') echo 'selected'; ?>>Cancelado</option>
        </select>
        <br><br>
        <input type="hidden" name="id_pedido" value="<?php echo $_GET['id_pedido']; ?>">
        <input id="botao" class="btn btn-primary mb1 bg-fuchsia" type="submit" name="btn_att" value="Atualizar" onclick="document.frm_att.action='att_env.php'">
    </form>
            </container>
        </section>
        <script src="../js/script.js"></script>
    </body>
    
    </html>
 