<?php
session_start();
include 'conexao.php';
date_default_timezone_set('America/Sao_Paulo');

if (!isset($_SESSION['logged_in']) || !$_SESSION['logged_in']) {
    header("Location: login.php");
} else {

    $sql = mysql_query("SELECT MAX(item) as item,descricao, obs, MAX(preco) as preco, COUNT(cod_bolo) as quantidade, SUM(preco) as subtotal FROM tb_carrinho
    WHERE email = '{$_SESSION['usermail']}'
    GROUP BY cod_bolo,descricao,obs");

    if(isset($_GET['menos'])){
        $sql = mysql_query("DELETE FROM tb_carrinho
        WHERE item =" . $_GET['menos']);
        header("Location: carrinho.php");

    }

    if(isset($_GET['mais'])){
        $linhas = mysql_fetch_assoc(mysql_query("SELECT * FROM tb_carrinho
        WHERE item =" . $_GET['mais']));

        mysql_query("INSERT INTO tb_carrinho (email,cod_bolo,obs,descricao,preco,quantidade)
        VALUES ('{$linhas['email']}','{$linhas['cod_bolo']}','{$linhas['obs']}','{$linhas['descricao']}','{$linhas['preco']}','{$linhas['quantidade']}')");
        header("Location: carrinho.php");
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
        <div id="btn_carrinho_sub" class="bx bx-cart"></div>
        <div id="menu-btn" class="bx bx-menu"></div>
        </div>
    </header>
<!--- FIM DO CABEÇALHO --->


<section class="table-responsive">
	<table class="table table-hover table-bordered">
		<thead class="thead-dark">    
<tr>
                        <th colspan="7e" style="padding:10px" class="tabela">MEU CARRINHO</th>
                    </tr>
                <tr>
                    <th scope="col">DESCRIÇÃO</th>
                    <th scope="col">OBS</th>
                    <th scope="col">PREÇO</th>
                    <th scope="col">QUANTIDADE</th>
                    <th scope="col">SUBTOTAL</th>
                    <th scope="col"></th>
                    <th scope="col"></th>
                </tr>
                </thead>
                <?php
                $totalpedido = 0;
                    while($linha = mysql_fetch_assoc($sql)) {
                        $subtotal = $linha['subtotal'];
                        $totalpedido += $subtotal;
                ?>
                <tr>
                    <td class="linha-tabela"><?php echo $linha['descricao']; ?></td>
                    <td class="linha-tabela"><?php echo $linha['obs']; ?></td>
                    <td class="linha-tabela">R$<?php echo $linha['preco']; ?>,00</td>
                    <td class="linha-tabela"><?php echo $linha['quantidade']; ?></td>
                    <td class="linha-tabela">R$<?php echo $linha['subtotal']; ?>,00</td>
                    <th><a href="carrinho.php?menos='<?php echo $linha['item']; ?>'"><i class="bx bx-minus"></i></a></th>	       
                    <th><a href="carrinho.php?mais='<?php echo $linha['item']; ?>'"><i class="bx bx-plus"></i></a></th>	       
                </tr>
                <?php
                    }
                ?>
        </table>
        <form name="frm_carrinho" class="filtrar-pedidos" method="post" action="pedidos.php">
            <input type="text" class="form-control" id="txt_total_pdd" name="txt_total_pdd" value="<?php echo "Total da compra: R$"; echo $totalpedido; echo ",00" ?>" readonly>
            <input type="text" class="form-control" id="txt_endereco" name="txt_endereco" placeholder="Endereço de entrega" required>
            <input type="hidden" id="txt_data_ped" name="txt_data_ped" value="<?php echo date('ymdHis'); ?>">
            <input type="submit" class="btn btn-primary" id="btn_fazerPedido" name="btn_fazerPedido" value="Fazer Pedido" onclick="document.frm_carrinho.action='fazer_pedido.php'">
		</form>

    </div>
    <script src="../js/script.js"></script>
</body>
</html>
<?php
}
?>