<?php
session_start();
if(isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true){
    unset($_SESSION['logged_in']);
    unset($_SESSION['username']);
    unset($_SESSION['useremail']);
    session_destroy();
    echo "Deslogado com sucesso";
    header("Location: ..\index.php");
} else {
    echo "Erro: sessão não encontrada";
}
?>
