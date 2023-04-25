<?php
include 'conexao.php';

if(isset($_GET['edit'])){
    $renavam = $_GET['edit'];
    $sql = "SELECT * FROM tb_carros WHERE renavam = $renavam";
    $resultado = mysql_query($sql);
    if($resultado){
        $linha = mysql_fetch_assoc($resultado);
        $monta = $linha['monta'];
        $model = $linha['model'];
        $ano = $linha['ano'];
        $valor = $linha['valor'];
        $ipva = $linha['ipva'];
    }
}

if(isset($_POST['atualizar'])){
    $renav = $_POST['txt_renavam'];
    $mont = $_POST['sel_monta'];
    $mod = $_POST['txt_model'];
    $anof = $_POST['txt_ano'];
    $valor = $_POST['txt_valor'];
    $val = str_replace('R$', '', $valor);

    $ipvaa = $_POST['txt_ipva'];
    if ($anof > 1996) {
        $ipvanov = $val * 0.04;}
    else {$ipvanov = 0;}


    $sql = mysql_query("UPDATE tb_carros SET monta='$mont', model='$mod', ano='$anof', valor='$val', ipva='$ipvanov' WHERE renavam=$renav");

    if($sql){
        echo '<script type="text/javascript">',
            'alert("Veiculo atualizado!");',
            'window.location.href = "listagem.php";',
            '</script>';
    }else{
        echo '<script type="text/javascript">',
            'alert("Erro ao atualizar veiculo!");',
            'window.location.href = "listagem.php";',
            '</script>';
    }
}
?>

<html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet" href="https://unpkg.com/boxicons@latest/css/boxicons.min.css">
    <script src="js/script.js"></script>
</head>

<body>
<div class="form">
    <form name="form_att" method="post">

        <h2>Cadastro de veículos</h2>

        <div class="form-group">
            <label for="txt_renavam">RENAVAM:</label>
            <input class="inputs" type="text" name="txt_renavam" id="txt_renavam" required value="<?php echo $renavam; ?>" readonly>
        </div>

        <div class="form-group">
            <label for="txt_model">MODELO DO VEÍCULO:</label>
            <input class="inputs" type="text" name="txt_model" id="txt_model" required value="<?php echo $model; ?>">
        </div>

            <div class="form-group">
                <label for="sel_monta">MONTADORA:</label>
                <select name="sel_monta" id="sel_monta" class="monta">
                    <option disabled selected>Selecione</option>
                    <option value="Chevrolet" <?php if($monta == 'Chevrolet') echo 'selected'; ?>>Chevrolet</option>
                    <option value="Fiat" <?php if($monta == 'Fiat') echo 'selected'; ?>>Fiat</option>
                    <option value="Ford" <?php if($monta == 'Ford') echo 'selected'; ?>>Ford</option>
                    <option value="Honda" <?php if($monta == 'Honda') echo 'selected'; ?>>Honda</option>
                    <option value="Hyundai" <?php if($monta == 'Hyundai') echo 'selected'; ?>>Hyundai</option>
                    <option value="Jeep" <?php if($monta == 'Jeep') echo 'selected'; ?>>Jeep</option>
                    <option value="Nissan" <?php if($monta == 'Nissan') echo 'selected'; ?>>Nissan</option>
                    <option value="Renault" <?php if($monta == 'Renault') echo 'selected'; ?>>Renault</option>
                    <option value="Toyota" <?php if($monta == 'Toyota') echo 'selected'; ?>>Toyota</option>
                    <option value="Volkswagen" <?php if($monta == 'Volkswagen') echo 'selected'; ?>>Volkswagen</option>
                </select>
            </div>

            <div class="form-group">
                <label for="txt_ano">ANO:</label>
                <input class="inputs" type="text" name="txt_ano" id="txt_ano" required value="<?php echo $ano; ?>">
            </div>


        <div class="form-group">
            <label for="txt_valor">VALOR DO VEÍCULO:</label>
            <input class="inputs" type="text" name="txt_valor" id="txt_valor" required value="<?php echo 'R$'. $valor; ?>">
        </div>

        <div class="form-group">
            <label for="txt_ipva">IPVA:</label>
            <input class="inputs" type="text" name="txt_ipva" id="txt_ipva" required value="<?php echo 'R$' .$ipva; ?>" readonly>
        </div>

        <div class="form-group">
                <center><input type="submit" value="ATUALIZAR" class="voltar" name="atualizar">
        </div>
        </form>

    <form name="form_voltar" method="post">
    <center><input type="button" value="VOLTAR" id="btn_voltar" onclick="volte()" class="voltar">
</div>
</body>
<script src="js/script.js"></script>

</body>
</html>