<?php

include 'conexao.php';

if(isset($_POST['busca_nome']) != '') {
	$sql = mysql_query("select * from tb_funcionarios where Nome_Funcionario like  '{$_POST['busca_nome']}%' order by N_Registro asc");
} else {
	$sql = mysql_query("select * from tb_funcionarios order by N_Registro asc");
}

if(isset($_GET['apagar'])){
	$sql = mysql_query("delete from tb_funcionarios where Nome_Funcionario=". $_GET['apagar']);
	 echo "<br>";
	 echo "<center>";
	 echo "<hr>";
	 echo "Funcionario excluido com sucesso!";
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
Digite um funcionario: <input type="text" name="busca_nome"><input type="submit" value="FILTRAR">
</form>


<table border="1" align="center">
		    <tr>
			<th colspan="8e" style="padding:10px" class="tabela">LISTA DE FUNCIONARIOS</th>
			</tr>
			<tr>
			<th class="tabela">Nº REGISTRO</th>
			<th class="tabela">NOME</th>
			<th class="tabela">DATA ADMISSAO</th>
			<th class="tabela">CARGO</th>
			<th class="tabela">SALARIO BRUTO</th>
			<th class="tabela">INSS</th>
            <th class="tabela">SALARIO LIQUIDO</th>
            <th class="tabela">APAGAR</th>
			</tr>
			<tr>
			
			<?php
				while($linha = mysql_fetch_assoc($sql)) {
			?>
			<td style="padding:5px" align="center"><?php echo $linha['N_Registro']; ?></td>
			<td style="padding:5px" align="center"><?php echo $linha['Nome_Funcionario']; ?></td>
			<td style="padding:5px" align="center"><?php echo $linha['data_admissao']; ?></td>
			<td style="padding:5px" align="center"><?php echo $linha['cargo']; ?></td>
			<td style="padding:5px" align="center"><?php echo 'R$'.$linha['salario_bruto']; ?></td>
			<td style="padding:5px" align="center"><?php echo 'R$'.$linha['inss']; ?></td>
			<td style="padding:5px" align="center"><?php echo 'R$'.$linha['salario_liquido']; ?></td>
            <th><a href="listagem.php?apagar='<?php echo $linha['Nome_Funcionario']; ?>'"><img src='deletar_usuario.png'></a></th>
	       <tr>
            			
			<?php  } 
			  
              
			  echo "<br>";
			  echo "<center>";
			  echo "<hr>";
              echo "<a href=\"home_funcionarios.html\">Retornar a gravacao </a>"; 
			  echo "<hr>";
              echo "<br>";
              echo "<br>";
			?>
</table>
</body>
</html>





