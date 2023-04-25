<?php 

    include 'conexao.php';
    $txt_renavam = $_POST ["txt_renavam"];
    $txt_model = $_POST ["txt_model"];
    $sel_monta = $_POST ["sel_monta"];
    $txt_placa = $_POST ["txt_placa"];
    $txt_ano = $_POST ["txt_ano"];
    $txt_valor = $_POST ["txt_valor"];
    if ($txt_ano > 1996) {
        $ipva = $txt_valor * 0.04;}
    else {$ipva = 0;}
    $sql =mysql_query ("SELECT * FROM tb_carros
                        WHERE renavam='$txt_renavam'");

    if (mysql_num_rows($sql) > 0) {
        echo '<script type="text/javascript">',
            'alert("Veiculo ja registrado!");',
            'window.location.href = "multimarcas.php";',
            '</script>';
    } else {
        $sql=mysql_query ("INSERT INTO tb_carros(renavam,model,monta,placa,ano,valor,ipva) 
                            VALUES ('$txt_renavam','$txt_model','$sel_monta','$txt_placa','$txt_ano','$txt_valor','$ipva')");

        echo '<script type="text/javascript">',
            'alert("Veiculo registrado com sucesso!");',
            'window.location.href = "multimarcas.php";',
            '</script>';

    }

?>