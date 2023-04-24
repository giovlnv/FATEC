<?php

include 'conexao.php';

if(isset($_POST['busca_desc']) != '') {
	$sql = mysql_query("SELECT * FROM tb_carros WHERE model LIKE  '{$_POST['busca_desc']}%' ORDER BY renavam ASC");
} else {
	$sql = mysql_query("SELECT * FROM tb_carros ORDER BY renavam ASC");
}

if(isset($_GET['apagar'])){
	$sql = mysql_query("delete from tb_carros where renavam=". $_GET['apagar']);
	 echo "<br>";
	 echo "<center>";
	 echo "<hr>";
	 echo "Veículo excluido com sucesso!";
	 echo "<br>";
	 echo "<br>";
	 echo "<a href=\"listagem.php\">Voltar</a>"; 
	 echo "<hr>";
	return false;
	
}

?>

<html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="css/style.css">
</head>
<body>	  
<center>
<br><br>
<form name="frm_cadastro" method="POST" action="listagem.php">
Busque pela descrição: <input type="text" name="busca_desc"><input type="submit" value="FILTRAR">
</form>


<table border="1" align="center">

			<tr>
			<th class="tabela">RENAVAM</th>
			<th class="tabela">DESCRIÇÃO</th>
			<th class="tabela">ANO FABRIC</th>
			<th class="tabela">VALOR</th>
			<th class="tabela">IPVA</th>
			</tr>
			<tr>
			
			<?php
				while($linha = mysql_fetch_assoc($sql)) {
			?>
			<td><?php echo $linha['renavam']; ?></td>
			<td><?php echo $linha['monta']; echo $linha['model']?></td>
			<td><?php echo $linha['ano']; ?></td>
			<td><?php echo 'R$'.$linha['valor']; ?></td>
			<td><?php echo 'R$'.$linha['ipva']; ?></td>
            <th><a href="listagem.php?apagar='<?php echo $linha['renavam']; ?>'"><i class="bx bx-trash"></i></a></th>
            <th><a href="listagem.php?edit='<?php echo $linha['renavam']; ?>'"><i class="bx bx-edit"></i></a></th>
			<tr>
            			
			<?php  } 
			  
              
			  echo "<br>";
			  echo "<center>";
			  echo "<hr>";
              echo "<a href=\"multimarcas.php\">Retornar a gravacao </a>"; 
			  echo "<hr>";
              echo "<br>";
              echo "<br>";
			?>
</table>
</body>
</html>





