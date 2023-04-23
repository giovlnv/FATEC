<?php
session_start();

if(isset($_SESSION['form_preench'])) {
    $nome = $_SESSION['nome'];
    $email = $_SESSION['email'];
    $tel = $_SESSION['tel'];
    $tam_pedido = $_SESSION['tam_pedido'];
    $massa_pedido = $_SESSION['massa_pedido'];
    $recheio_pedido = $_SESSION['recheio_pedido'];
    $obs = $_SESSION['obs'];
    $ende = $_SESSION['ende'];
} else {
    $nome ='';
    $email ='';
    $tel ='';    
    $tam_pedido ='';
    $massa_pedido ='';
    $recheio_pedido ='';
    $obs ='';    
    $ende ='';
}
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Bolos para sua festa de aniversário, casamento ou comemorações.">
    <link rel="icon" href="/img/icone.png   " color="#783b31" type="image/x-icon">
    <title>Dolcevitta</title>
    <link rel="stylesheet"
        href="https://unpkg.com/boxicons@latest/css/boxicons.min.css">

    <link rel="stylesheet" 
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">

    <link rel="stylesheet"
        href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"
        crossorigin="anonymous">

        <link rel="stylesheet" href="css/style.css">
    </head>
    
<body class="index">

    <!-- Cabeçalho -->
    <header class="header">
        
        <a href="#" class="logo"><i class="fas fa-birthday-cake"></i>Dolcevitta</a>
        <nav class="navbar" onclick="abrirMenu()">
            <a href="#home">home</a>
            <a href="#sobre">sobre</a>
            <a href="#produtos">produtos</a>
            <a href="#pedidos">fazer pedido</a>
            <?php 
            if(isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true && $_SESSION['username'] == 'admin') {
                echo '<a href="php\pedidos_admin.php">pedidos</a>';
            } elseif (isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true) {
                echo '<a href="php\pedidos.php">meus pedidos</a>';
            } else {
                echo '<a href="php\login.php">meus pedidos</a>';}
            
            ?>
</nav>


        <div class="icons">
        <?php
            if(isset($_SESSION['logged_in']) && $_SESSION['logged_in'] == true){
                echo 'Olá, '.$_SESSION['username'].'<div id="btn_logout" class="bx bx-log-out-circle"></div>';
            } else {
                echo '<div id="btn_login" class="bx bx-log-in-circle"></div>';
            }
        ?>

        <div id="menu-btn" class="bx bx-menu"></div>
</div>


    </header>
    <!-- Fim Cabeçalho -->

    <!-- Home -->
    <section class="home" id="home">
        <div class="texto">
            <h3>QUEREMOS TORNAR O MUNDO UM LUGAR MAIS DOCE</h3>
            <p>Aproveitar cada momento, cada sentimento, cada pedaço</p>
        </div>
    </section>
    <!-- Fim Home -->

    <!-- Sobre Nós-->
    <div class="ancora" id="sobre"></div>
    <section class="sobre">
        <h1>SOBRE <span>NÓS</span></h1>
        <div class="duas-secoes">
            <container class="metade">
                <img src="img/worker-cake.jpg" class="rounded img-fluid" alt="Algumas pessoas numa loja de bolos" width="100%">
            </container>
    
            <container class="metade">
                <h2>QUALIDADE, PAIXÃO E SABOR</h2>
                <p>
                    Qualidade dos ingredientes, satisfação do cliente, paixão pelo que fazemos e um sabor incrível é o que importa para nós da Dolcevitta. Esses valores são parte dos ingredientes presentes em cada bolo.
                </p>
            </container>
        </div>
    </section>
    <!-- Fim Sobre Nós-->

    <!-- Produtos -->
    <div class="ancora" id="produtos"></div>
    <section class="produtos">
        <h1>NOSSOS<span> BOLOS<span></h1>
        <div class="bloco-produtos">
            <div class="vitrine">
                <container class="produto-vitrine">
                    <img src="img/cake-slice-chocolate-trufado.png" class="rounded img-fluid" data-massa="Chocolate" data-recheio="Brigadeiro">
                    <h3>Chocolate Trufado</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-abacaxi.png" class="rounded img-fluid" data-massa="Baunilha" data-recheio="Abacaxi em Calda">
                    <h3>Abacaxi em Calda</h3>
                </container>
            </div>

            <div class="vitrine">
                <container class="produto-vitrine">
                    <img src="img/cake-slice-avela.png" class="rounded img-fluid" data-massa="Chocolate" data-recheio="Creme de Avelã">
                    <h3>Creme de Avelã</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-limao.png" class="rounded img-fluid" data-massa="Baunilha" data-recheio="Limão Siciliano">
                    <h3>Limão Siciliano</h3>
                </container>
            </div>
        </div>

        <div class="bloco-produtos">

            <div class="vitrine">
                <container class="produto-vitrine">
                    <img src="img/cake-slice-banoffee.png" class="rounded img-fluid" data-massa="Baunilha" data-recheio="Banoffee">
                    <h3 class="h3">Banoffee</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-frutas-vermelhas.png" class="rounded img-fluid" data-massa="Baunilha" data-recheio="Frutas Vermelhas">
                    <h3 class="h3">Frutas Vermelhas</h3>
                </container>
            </div>

            <div class="vitrine">
                <container class="produto-vitrine">
                    <img src="img/cake-slice-floresta-negra.png" class="rounded img-fluid" data-massa="Chocolate" data-recheio="Coco">
                    <h3>Floresta Negra</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-red-velvet.png" class="rounded img-fluid" data-massa="Red Velvet" data-recheio="Cream Cheese">
                    <h3>Red Velvet</h3>
                </container>
            </div>
        </div>
        
    </section>
    <!--Fim Produtos -->

    <!-- Pedidos -->
    <div class="ancora" id="pedidos"></div>
    <section class="sobre">
        <h1>MONTE <span>SEU</span> BOLO</h1>
        <div class="duas-secoes">
            <container class="metade">
                <img src="img/pedido.png" class="rounded img-fluid" alt="Um desenho de uma mulher preparando o pedido" width="100%">
            </container>
    
            <container class="metade">
            <form name="frm_pedidos" method="post">
                <div class="duas-secoes">
                    <input type="text" class="form-control" id="txt_nome" name="txt_nome" placeholder="Nome" value="<?php echo $nome; ?>" required>
                    <input type="email" class="form-control" id="txt_email" name="txt_email" placeholder="E-mail" value="<?php echo $email; ?>" required>
                    <input type="number" class="form-control" id="txt_tel" name="txt_tel" placeholder="Celular" value="<?php echo $tel; ?>" required>
                </div>
                <select class="custom-select my-1 mr-sm-2" id="tam_pedido" name="tam_pedido" required>
                    <option selected value="">Escolha um tamanho...</option>
                    <option value="P" <?php if($tam_pedido == 'P') echo 'selected'; ?>>Pequeno (700g)</option>
                    <option value="M" <?php if($tam_pedido == 'M') echo 'selected'; ?>>Médio (1,5kg)</option>
                    <option value="G" <?php if($tam_pedido == 'G') echo 'selected'; ?>>Grande (2kg)</option>
                    <option value="S" <?php if($tam_pedido == 'S') echo 'selected'; ?>>Super (3kg)</option>
                </select>

                <select class="custom-select my-1 mr-sm-2" id="massa_pedido" name="massa_pedido" required>
                    <option selected value="">Escolha uma massa...</option>
                    <option value="Baunilha" <?php if($massa_pedido == 'Baunilha') echo 'selected'; ?>>Baunilha</option>
                    <option value="Chocolate" <?php if($massa_pedido == 'Chocolate') echo 'selected'; ?>>Chocolate</option>
                    <option value="Red Velvet" <?php if($massa_pedido == 'Red Velvet') echo 'selected'; ?>>Red Velvet</option>
                </select>

                <select class="custom-select my-1 mr-sm-2" id="recheio_pedido" name="recheio_pedido" required>
                    <option selected value="">Escolha um recheio...</option>
                    <option value="Abacaxi em Calda" <?php if($recheio_pedido == 'Abacaxi em Calda') echo 'selected'; ?>>Abacaxi em Calda</option>
                    <option value="Amendoim" <?php if($recheio_pedido == 'Amendoim') echo 'selected'; ?>>Amendoim</option>
                    <option value="Banoffee" <?php if($recheio_pedido == 'Banoffe') echo 'selected'; ?>>Banoffee</option>
                    <option value="Baunilha" <?php if($recheio_pedido == 'Baunilha') echo 'selected'; ?>>Baunilha</option>
                    <option value="Brigadeiro" <?php if($recheio_pedido == 'Brigadeiro') echo 'selected'; ?>>Brigadeiro</option>
                    <option value="Cream Cheese" <?php if($recheio_pedido == 'Cream Cheese') echo 'selected'; ?>>Cream Cheese</option>
                    <option value="Creme de Avelã" <?php if($recheio_pedido == 'Creme de Avelã') echo 'selected'; ?>>Creme de Avelã</option>
                    <option value="Coco" <?php if($recheio_pedido == 'Coco') echo 'selected'; ?>>Coco</option>
                    <option value="Frutas Vermelhas" <?php if($recheio_pedido == 'Frutas Vermelhas') echo 'selected'; ?>>Frutas Vermelhas</option>
                    <option value="Limão Siciliano" <?php if($recheio_pedido == 'Limão Siciliano') echo 'selected'; ?>>Limão Siciliano</option>
                    <option value="Leite em Pó" <?php if($recheio_pedido == 'Leite em Pó') echo 'selected'; ?>>Leite em Pó</option>
                    <option value="Morango" <?php if($recheio_pedido == 'Morango') echo 'selected'; ?>>Morango</option>
                </select>
                
                <input type="text'" class="form-control" id="txt_obs" name="txt_obs" placeholder="Observações ou comentários" value="<?php echo $obs; ?>">
                <input type="text" class="form-control" id="txt_endereco" name="txt_endereco" placeholder="Endereço de entrega" value="<?php echo $ende; ?>">
                <input id="botao" type="submit" name="btn_pedir" value="Fazer Pedido" class="btn btn-primary mb1 bg-fuchsia" onclick="<?php if(isset($_SESSION['logged_in'])) { echo "document.frm_pedidos.action='php/fazer_pedido.php'"; } else { echo "document.frm_pedidos.action='php/preforms.php'"; } ?>">
            </form>

            </container>
        </div>
    </section>
    <!-- Fim Pedidos -->

    <footer>
        <p>©Dolcevitta | Todos Direitos Reservados</p>
    </footer>

    <script src="js/script.js"></script>

</body>
</html>