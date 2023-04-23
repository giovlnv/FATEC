<?php
session_start();
include 'conexao.php';

    $id_pedido = $_POST['id_pedido'];
    $novo_status = $_POST['status_pedido'];
    $sql = mysql_query("UPDATE tb_pedidos SET status_pdd = '$novo_status' WHERE indice = $id_pedido");

    header("Location: pedidos_admin.php");
    exit();
?>