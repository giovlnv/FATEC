<?php
session_start();
include 'conexao.php';

if (!isset($_SESSION['logged_in']) || !$_SESSION['logged_in']) {
    header("Location: login.php");
} else {

    if(isset($_POST['busca_pedidos']) != '') {
        $sql = mysql_query("SELECT * FROM tb_pedidos WHERE email LIKE '{$_SESSION['usermail']}'
        AND nome LIKE '{$_POST['busca_pedidos']}%' 
        OR status_pdd LIKE '{$_POST['busca_pedidos']}%' AND email LIKE '{$_SESSION['usermail']}'
        OR ende LIKE '{$_POST['busca_pedidos']}%' AND email LIKE '{$_SESSION['usermail']}'
        ORDER BY indice ASC");
    } else {
        $sql = mysql_query("SELECT * FROM tb_pedidos WHERE email LIKE '{$_SESSION['usermail']}' ORDER BY indice ASC");
    }
    
    if(isset($_GET['apagar'])){
    $sql = mysql_query("DELETE FROM tb_pedidos WHERE indice=". $_GET['apagar']);
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
                    <p>Pedido excluído com sucesso.</p>
                    <input id="botao" class="btn btn-primary mb1 bg-fuchsia" type="button" name="btn_voltar" value="Voltar" onclick="window.location.href='pedidos.php';">
            </container>
        </section>
        <script src="../js/script.js"></script>
    </body>
    
    </html>
<?php
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
            <?php
                if(isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true){
                    echo 'Olá, '.$_SESSION['username'].'<div id="btn_logout_sub" class="bx bx-log-out-circle"></div>';
                } else {
                    echo '<div id="btn_login_sub" class="bx bx-log-in-circle"></div>';
                }
            ?>
            <div id="menu-btn" class="bx bx-menu"></div>
        </div>
    </header>
<!--- FIM DO CABEÇALHO --->


<section class="table-responsive">
		<form name="frm_pedidos" class="filtrar-pedidos" method="POST" action="pedidos.php">
			<input type="text" placeholder="Filtrar" class="form-control" name="busca_pedidos">
			<input type="submit" class="btn btn-primary" value="Buscar">
		</form>
	<table class="table table-hover table-bordered">
		<thead class="thead-dark">    
<tr>
                        <th colspan="10e" style="padding:10px" class="tabela">MEUS PEDIDOS</th>
                    </tr>
                <tr>
                    <th scope="col">NUMERO</th>
                    <th scope="col">NOME</th>
                    <th scope="col">MASSA</th>
                    <th scope="col">RECHEIO</th>
                    <th scope="col">TAMANHO</th>
                    <th scope="col">OBS</th>
                    <th scope="col">ENDEREÇO</th>
                    <th scope="col">STATUS</th>
                    <th scope="col"></th>
                </tr>
                </thead>
                <?php
                    while($linha = mysql_fetch_assoc($sql)) {
                ?>
                <tr>
                    <td class="linha-tabela"><?php echo $linha['indice']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['nome']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['massa']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['recheio']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['tam']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['obs']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['ende']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['status_pdd']; ?></td>
                    <th><a href="pedidos.php?apagar='<?php echo $linha['indice']; ?>'"><i class="bx bx-trash"></i></a></th>	       
                </tr>
                <?php
                    }
                ?>
        </table>
    </div>
    <script src="../js/script.js"></script>
</body>
</html>
<?php
}
?>