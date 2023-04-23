<?php
session_start();

    $_SESSION['form_preench'] = true;
    $_SESSION['nome'] = $_POST["txt_nome"];
    $_SESSION['email'] = $_POST["txt_email"];
    $_SESSION['tel'] = $_POST["txt_tel"];
    $_SESSION['tam_pedido'] = $_POST["tam_pedido"];
    $_SESSION['massa_pedido'] = $_POST["massa_pedido"];
    $_SESSION['recheio_pedido'] = $_POST["recheio_pedido"];
    $_SESSION['obs'] = $_POST["txt_obs"];
    $_SESSION['ende'] = $_POST["txt_endereco"];   
    header("Location: login.php");
    
?>