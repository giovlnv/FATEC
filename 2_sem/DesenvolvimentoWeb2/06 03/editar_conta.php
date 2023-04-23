<html>
<body>
<center>
<h1>
<hr>
Alterar conta
<hr>
<form name="form1" method="POST">
Usuário:<br><input type="text" name="txt_usuario" value="<?php if (isset($_GET['edit'])) echo $_GET['edit'] ?>" readonly><br>
Email:<br><input type="text"  name="txt_email" value="<?php if (isset($_GET['edit'])) echo $_GET['email'] ?>" disabled><br>
Senha:<br><input type="text"  name="txt_senha" value="<?php if (isset($_GET['edit'])) echo $_GET['senha'] ?>"><br>
<br>
<INPUT TYPE="submit" name="bt_editar" VALUE="Alterar"  onClick="document.form1.action='editar.php'">
<INPUT TYPE="submit" name="bt_login" VALUE="Retornar login"  onClick="document.form1.action='login.php'">
