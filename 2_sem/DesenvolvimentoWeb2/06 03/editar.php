<?php
   include 'conexao.php';
		 
		 $usuario = $_POST [ "txt_usuario"];
         $senha = $_POST["txt_senha"];		
		
		      $sql =mysql_query ("update tb_cadastro set senha='$senha' where usuario='$usuario'") ; 
              echo "<center>";		  
		      echo "<hr>";
		      echo "Conta alterada com sucesso!";
		      echo "<hr>";
		      echo "<br>";
	          echo "<a href=\"login.php\">Retornar ao login </a>"; 
?>
