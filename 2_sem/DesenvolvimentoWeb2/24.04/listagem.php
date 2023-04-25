<?php

include 'conexao.php';

if(isset($_POST['busca_desc']) != '') {
	$sql = mysql_query("SELECT * FROM tb_carros WHERE model LIKE  '{$_POST['busca_desc']}%' ORDER BY renavam ASC");
} else {
	$sql = mysql_query("SELECT * FROM tb_carros ORDER BY renavam ASC");
}

if(isset($_GET['apagar'])){
	$sql = mysql_query("delete from tb_carros where renavam=". $_GET['apagar']);
	echo '<script type="text/javascript">',
     'alert("Veiculo excluido!");',
	 'window.location.href = "listagem.php";',
     '</script>';
	return false;
	
}

?>

<html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet"
        href="https://unpkg.com/boxicons@latest/css/boxicons.min.css">

</head>
<body>	  
<center>
<br><br>
<div class="box">
<form class="lista" name="frm_cadastro" method="POST" action="listagem.php">
Busque pela descrição: <input class="busca" type="text" name="busca_desc">&nbsp;&nbsp;<input class="voltar" type="submit" value="FILTRAR">
</form>
<br><br>

<table class="table">
		<thead>    
			<tr>
				<th colspan="11e"><center>LISTA DE VEÍCULOS</center></th>
			</tr>
			<tr>
			<th scope="col">RENAVAM</th>
			<th scope="col">DESCRIÇÃO</th>
			<th scope="col">ANO FABRIC</th>
			<th scope="col">VALOR</th>
			<th scope="col">IPVA</th>
			<th scope="col"></th>
			<th scope="col"></th>
			</tr>
			<tr>
		</thead>
		<tbody>	
			<?php
				while($linha = mysql_fetch_assoc($sql)) {
			?>
			<td class="linha-tabela"><?php echo $linha['renavam']; ?></td>
			<td class="linha-tabela"><?php echo $linha['monta']; echo ' '; echo $linha['model']?></td>
			<td class="linha-tabela"><?php echo $linha['ano']; ?></td>
			<td class="linha-tabela"><?php echo 'R$'.$linha['valor']; ?></td>
			<td class="linha-tabela"><?php echo 'R$'.$linha['ipva']; ?></td>
            <th class="linha-tabela"><a href="listagem.php?apagar='<?php echo $linha['renavam']; ?>'"><i class="bx bx-trash"></i></a></th>
            <th class="linha-tabela"><a href="listagem.php?edit='<?php echo $linha['renavam']; ?>'"><i class="bx bx-edit"></i></a></th>
			<tr>
		</tbody>
			<?php  } 
			?>
</table>
<br><br>
<input type="button" value="VOLTAR" id="btn_voltar" onclick="voltar()" class="voltar">
</div>
</body>
<script src="js/script.js"></script>

</html>