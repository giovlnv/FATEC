<?php
session_start();
include 'conexao.php';
		 
$nome = $_POST["txt_nome"];
$email = $_POST["txt_email"];
$telefone = $_POST["txt_tel"];
$tamanho = $_POST["tam_pedido"];
$massa = $_POST["massa_pedido"];
$recheio = $_POST["recheio_pedido"];
$obs = $_POST["txt_obs"];
$ende = $_POST["txt_endereco"];
$status = 'Realizado';
unset($_SESSION['form_preench']);


     $sql = mysql_query("INSERT INTO tb_pedidos (nome,email,telefone,tam,massa,recheio,obs,ende,status_pdd)
     VALUES ('$nome','$email','$telefone','$tamanho','$massa','$recheio','$obs','$ende','$status')");
      
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
                        <h2>Pedido registrado com sucesso.</h2>
                        <input id="botao" class="btn btn-primary mb1 bg-fuchsia" type="button" name="btn_consultar" value="Consultar" onclick="window.location.href='pedidos.php';">
            </container>
      </section>
      <script src="../js/script.js"></script>
</body>

</html>