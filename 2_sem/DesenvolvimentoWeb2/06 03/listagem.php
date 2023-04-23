<?php

include 'conexao.php';

if(isset($_POST['busca_nome']) != '') {
	$sql = mysql_query("select * from tb_cadastro where usuario like  '{$_POST['busca_nome']}%' order by usuario asc");
} else {
	$sql = mysql_query("select * from tb_cadastro order by usuario asc");
}


if(isset($_GET['apagar'])){
	$sql = mysql_query("delete from tb_cadastro where usuario=". $_GET['apagar']);
	 echo "<br>";
	 echo "<center>";
	 echo "<hr>";
	 echo "Usurio excluido com sucesso!";
	 echo "<br>";
	 echo "<br>";
	 echo "<a href=\"listagem.php\">Voltar</a>"; 
	 echo "<hr>";
	return false;
	
}

?>

<html>
<body>	  
<center>



<form name="frm_login" method="POST" action="listagem.php">
Digite um usuario: <input type="text" name="busca_nome"><input type="submit" value="FILTRAR">
</form>


<table border="1" align="center">
		    <tr>
			<th colspan="6e" bgcolor="lightskyblue">Lista de contas cadastradas</th>
			</tr>
			<tr>
			<th bgcolor="lightgrey">Usuario</th>
			<th bgcolor="lightgrey">E-mail</th>
			<th bgcolor="lightgrey">Senha</th>
			<th bgcolor="lightgrey">Apagar</th>
			</tr>
			<tr>
			
			<?php
				while($linha = mysql_fetch_assoc($sql)) {
			?>
			<td align="center"><?php echo $linha['usuario']; ?></td>
			<td align="center"><?php echo $linha['email']; ?></td>
			<td align="center"><?php echo $linha['senha']; ?></td>
	       <th><a href="listagem.php?apagar='<?php echo $linha['usuario']; ?>'"><img src='deletar_usuario.png'></a></th>
	       <tr>
				 			
		   <?php }  
			?>
			</table>

			<?php 
			  echo "<br>";
			  echo "<center>";
			  echo "<hr>";
		      echo "<a href=\"login.php\">Retornar ao login </a>"; 
			  echo "<hr>";
			?>

</body>
</html>





