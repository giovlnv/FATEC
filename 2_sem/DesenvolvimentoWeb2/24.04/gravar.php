<?php 

    include 'conexao.php';
    $txt_renavam = $_POST ["txt_renavam"];
    $txt_model = $_POST ["txt_model"];
    $sel_monta = $_POST ["sel_monta"];
    $txt_placa = $_POST ["txt_placa"];
    $txt_ano = $$_POST ["txt_ano"];
    $txt_valor = $$_POST ["txt_valor"];
    if ($txt_ano > 1996) {
        $ipva = $txt_valor * 0.04;}
    else {$ipva = 0;}
    $sql =mysql_query ("SELECT * FROM tb_carros
                        WHERE renavam='$txt_renavam'");

    if (mysql_num_rows($sql) > 0) {
        echo "<center>";
        echo "<hr>";
        echo "Veículo ja registrado!";
        echo "<hr>";
        echo "<br>";
    } else {
        $sql=mysql_query ("INSERT INTO tb_carros(renavam,model,monta,placa,ano,valor,ipva) 
                            VALUES ('$txt_renavam','$txt_model','$sel_monta','$txt_placa','$txt_ano','$txt_valor','$ipva')");
            echo "<center>";
            echo "<hr>";
            echo "Veículo cadastrado com sucesso!";
            echo "<hr>";
            echo "<br>";
            echo "<br>";
            echo "<center>";
            echo "<hr>";
            echo "<a href=\"multimarcas.php\">Retornar a gravacao </a>"; 
            echo "<hr>";

    }

?>