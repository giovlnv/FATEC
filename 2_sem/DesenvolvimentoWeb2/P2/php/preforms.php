<?php
session_start();

    $_SESSION['form_preench'] = true;
    $_SESSION['tam_pedido'] = $_POST["tam_pedido"];
    $_SESSION['massa_pedido'] = $_POST["massa_pedido"];
    $_SESSION['recheio_pedido'] = $_POST["recheio_pedido"];
    $_SESSION['adicional_pedido'] = $_POST["adicional_pedido"];
    $_SESSION['obs'] = $_POST["txt_obs"];
    header("Location: login.php");
    
?>