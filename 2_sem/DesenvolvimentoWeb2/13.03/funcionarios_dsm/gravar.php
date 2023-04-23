<?php 

    include 'conexao.php';
    $Nome_Funcionario = $_POST ["Nome_Funcionario"];
    $data_admissao = $_POST ["data_admissao"];
    $cargo = $_POST ["cargo"];
    $qtde_salarios = $_POST ["qtde_salarios"];
    $salario_bruto = $qtde_salarios * 1212;
    if ($salario_bruto>1300) {
        $inss = $salario_bruto * 0.11;}
    else {$inss = 0;}
    $salario_liquido = $salario_bruto - $inss;
    $sql =mysql_query ("SELECT * FROM tb_funcionarios
                        WHERE Nome_Funcionario='$Nome_Funcionario'");

    if (mysql_num_rows($sql) > 0) {
        echo "<center>";
        echo "<hr>";
        echo "Funcionario ja existe!";
        echo "<hr>";
        echo "<br>";
    } else {
        $sql=mysql_query ("INSERT INTO tb_funcionarios(Nome_Funcionario,data_admissao,cargo,qtde_salarios,salario_bruto,inss,salario_liquido) 
                            VALUES ('$Nome_Funcionario','$data_admissao','$cargo','$qtde_salarios','$salario_bruto','$inss','$salario_liquido')");
            echo "<center>";
            echo "<hr>";
            echo "Funcionario cadastrado com sucesso!";
            echo "<hr>";
            echo "<br>";
            echo "<br>";
            echo "<center>";
            echo "<hr>";
            echo "<a href=\"home_funcionarios.html\">Retornar a gravacao </a>"; 
            echo "<hr>";

    }

?>