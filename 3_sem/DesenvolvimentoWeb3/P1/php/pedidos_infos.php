<?php
session_start();
include 'conexao.php';

if (!isset($_SESSION['logged_in']) || !$_SESSION['logged_in']) {
    header("Location: login.php");
} else {
    
    if ($_SESSION['usermail'] !== "admin@admin" || $_SESSION['username'] !== "admin") {

    $sql = mysql_query("SELECT descricao, obs, preco/quantidade as preco_unit, quantidade,email,ende,num_pedido 
        FROM tb_pedidos WHERE email LIKE '{$_SESSION['usermail']}' AND num_pedido=". $_GET['info']);
    } else {
    $sql = mysql_query("SELECT descricao, obs, preco/quantidade as preco_unit, quantidade,email,ende,num_pedido 
    FROM tb_pedidos WHERE num_pedido=". $_GET['info']);
    }

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Bolos para sua festa de aniversário, casamento ou comemorações.">
    <link rel="icon" href="/img/icone.png   " color="#783b31" type="image/x-icon">
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
        	 <!-- Cabeçalho -->
    <header class="header">
        <a href="#"><img src="../img/logo.png" class="logo"></i></a>
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
<!--- FIM DO CABEÇALHO --->


<section class="table-responsive">
	<table class="table table-hover table-bordered">
		<thead class="thead-dark">    
<tr>
                        <th colspan="7e" style="padding:10px" class="tabela">DETALHES</th>
                    </tr>
                <tr>
                    <th scope="col">NUMERO</th>
                    <th scope="col">EMAIL</th>
                    <th scope="col">DESCRIÇÃO</th>
                    <th scope="col">VALOR UNIT</th>
                    <th scope="col">QTD</th>
                    <th scope="col">OBS</th>
                    <th scope="col">ENDEREÇO</th>
                </tr>
                </thead>
                <?php
                    while($linha = mysql_fetch_assoc($sql)) {
                ?>
                <tr>
                    <td class="linha-tabela"><?php echo $linha['num_pedido']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['email']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['descricao']; ?></td>
                    <td class="linha-tabela">R$<?php echo $linha['preco_unit']; ?>,00</td>
                    <td class="linha-tabela"><?php echo $linha['quantidade']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['obs']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['ende']; ?></td>
                </tr>
                <?php
                    }
                ?>
        </table>
        <div class="botao-voltar">
            <input type="button" class="btn btn-primary" value="Voltar" onclick="window.location.href='<?php 
                if($_SESSION['username'] == 'admin') {
                    echo 'pedidos_admin.php';
                } elseif (isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true) {
                    echo 'pedidos.php';
                }                        
                ?>'">
        </div>
    </div>
    <script src="../js/script.js"></script>
</body>
</html>
<?php
}

unset($_SESSION['num_pedido']);

?>