<?php
Include 'conexao.php';
$usuario = $_POST ["txt_usuario"];
$email = $_POST ["txt_email"];
$senha = $_POST ["txt_senha"];
$sql = mysql_query ("select * from tb_cadastro where
                    usuario='$usuario' or email='$email'");
if (mysql_num_rows($sql) > 0) {
    echo "<center>";
    echo "<hr>";
    echo "Conta ja cadastrada!";
    echo "<hr>";
    echo "<br>";
    } else {
        $sql = mysql_query ("insert into tb_cadastro (usuario,email,senha)
                            values ('$usuario','$email','$senha')");
        echo "<center>";
        echo "<hr>";
        echo "Conta cadastrada com sucesso!";
        echo "<hr>";
        echo "<br>";                    

    }