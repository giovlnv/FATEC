<?php
   
  include 'conexao.php';
		 
		 $usuario = $_POST["txt_usuario"];
		 $senha = $_POST["txt_senha"];
			 
		 $sql=mysql_query ("SELECT  * FROM tb_cadastro 
		            WHERE (usuario='$usuario'  or email='$usuario') 
					and senha='$senha'"); 
		 if (mysql_num_rows($sql) > 0) {
			 
		    echo "<center>";
			echo "<hr>";
			echo "Conta logada com sucesso!"; 
			echo "<hr>"; 
            echo "<br>";
			
            header('location:listagem.php');
			
			
			}	
	    else {
		      echo "<center>";
			  echo "<hr>";
		      echo "Login invalido!"; 
              echo "<hr>";
			  echo "<br>";
			  echo "<a href=\"login.php\">Voltar </a>";
			  }
?>