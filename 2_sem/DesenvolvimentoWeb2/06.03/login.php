<!DOCTYPE html>
<html>

<head>

    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title> LOGIN </title>
    <link rel="stylesheet" href="css/style.css">

</head>

<body backgroundcolor="white" text="black">

    <form name="frm_login" method="post">
        <fieldset>

            <h2>
                LOGIN
            </h2>
            <label for="nome">Usuario ou e-mail </label>
            <input type="text" name="txt_usuario" size="60" id="email">
            <p></p>
            <label for="senha">Senha: </label>
            <input type="password" name="txt_senha" size="10" id="senha">
            <p></p>
                <input id="botao" type="submit" name="btn_cadastrar" value="Entrar" onclick="document.frm_login.action='logar.php'">&nbsp;&nbsp;
                <input id="botao" type="submit" name="btn_login" value="Cadastrar" onclick="document.frm_login.action='cadastro.html'">&nbsp;&nbsp;
            </fieldset>
    </form>
</body>

</html>