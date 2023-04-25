<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastro de Veículos</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>

    <form class="cadastro" name="form_cadastro" method="post">

        <div class="form">
            <h2>Cadastro de veículos</h2>

            <label for="txt_renavam">RENAVAM: </label>
            <input type="text" name="txt_renavam" id="txt_renavam" required>

            <label for="txt_model">MODELO DO VEÍCULO: </label>
            <input type="text" name="txt_model" id="txt_model" required>

            <label for="sel_monta">MONTADORA: </label>
            <select name="sel_monta" id="sel_monta" class="sel_monta" required>
            <option value="Chevrolet">Chevrolet</option>
            <option value="Ford">Ford</option>
            <option value="Fiat">Fiat</option>
            <option value="Honda">Honda</option>
            <option value="Volkswagen">Volkswagen</option>
            </select>

            <label for="txt_placa">PLACA: </label>
            <input type="text" name="txt_placa" id="txt_placa" required>
            <label for="txt_ano">ANO: </label>
            <input type="text" name="txt_ano" id="txt_ano" required>

            <label for="txt_valor">VALOR DO VEÍCULO: </label>
            <input type="text" name="txt_valor" id="txt_valor" required>
            <br>
            <input type="submit" value="Cadastrar" onclick="document.form_cadastro.action='gravar.php'" class="enviar">
			<input type="submit" value="Listar" onclick="document.form_cadastro.action='listagem.php'" class="enviar">
        </div>

    </form>

</body>
</html>