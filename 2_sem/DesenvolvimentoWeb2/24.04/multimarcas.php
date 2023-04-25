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
<div class="form">
    <form name="form_cadastro" method="post">

        <h2>Cadastro de veículos</h2>

        <div class="form-group">
            <label for="txt_renavam">RENAVAM:</label>
            <input class="input" type="text" name="txt_renavam" id="txt_renavam" required>
        </div>

        <div class="form-group">
            <label for="txt_model">MODELO DO VEÍCULO:</label>
            <input class="input" type="text" name="txt_model" id="txt_model" required>
        </div>

            <div class="form-group">
                <label for="sel_monta">MONTADORA:</label>
                <select name="sel_monta" id="sel_monta" class="monta">
                    <option disabled selected>Selecione</option>
                    <option value="Chevrolet">Chevrolet</option>
                    <option value="Fiat">Fiat</option>
                    <option value="Ford">Ford</option>
                    <option value="Honda">Honda</option>
                    <option value="Hyundai">Hyundai</option>
                    <option value="Jeep">Jeep</option>
                    <option value="Nissan">Nissan</option>
                    <option value="Renault">Renault</option>
                    <option value="Toyota">Toyota</option>
                    <option value="Volkswagen">Volkswagen</option>
                </select>
            </div>

            <div class="form-group">
                <label for="txt_placa">PLACA:</label>
                <input class="input" type="text" name="txt_placa" id="txt_placa" required>
            </div>

            <div class="form-group">
                <label for="txt_ano">ANO:</label>
                <input class="input" type="text" name="txt_ano" id="txt_ano" required>
            </div>


        <div class="form-group">
            <label for="txt_valor">VALOR DO VEÍCULO:</label>
            <input class="input" type="text" name="txt_valor" id="txt_valor" required>
        </div>

        <div class="form-group">
                <input type="submit" value="CADASTRAR" onclick="document.form_cadastro.action='gravar.php'" class="enviar">
        </div>
        </form>

    <form name="form_listar" method="post">
            <input type="submit" value="LISTAR" onclick="document.form_listar.action='listagem.php'" class="enviar">
    </div>

</body>
</html>