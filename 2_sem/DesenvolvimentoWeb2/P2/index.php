<?php
session_start();

if(isset($_SESSION['form_preench'])) {
    $tam_pedido = $_SESSION['tam_pedido'];
    $massa_pedido = $_SESSION['massa_pedido'];
    $recheio_pedido = $_SESSION['recheio_pedido'];
    $adicional_pedido = $_SESSION['adicional_pedido'];
    $obs = $_SESSION['obs'];
    $ende = $_SESSION['ende'];
} else {   
    $tam_pedido ='';
    $massa_pedido ='';
    $recheio_pedido ='';
    $adicional_pedido = '';
    $obs ='';    
    $ende ='';
}

if(isset($_SESSION['logged_in'])) {
$login_status = 'logado';
} else {
$login_status = 'deslogado';
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
            <div id="btn_carrinho" class="bx bx-cart"></div>
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
                    <img src="img/cake-slice-chocolate-trufado.png" class="rounded img-fluid" data-massa="Ch" data-recheio="05" data-adc="A4">
                    <h3>Chocolate Trufado</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-abacaxi.png" class="rounded img-fluid" data-massa="Ba" data-recheio="01" data-adc="">
                    <h3>Abacaxi em Calda</h3>
                </container>
            </div>

            <div class="vitrine">
                <container class="produto-vitrine">
                    <img src="img/cake-slice-avela.png" class="rounded img-fluid" data-massa="Ch" data-recheio="08" data-adc="">
                    <h3>Creme de Avelã</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-limao.png" class="rounded img-fluid" data-massa="Ba" data-recheio="10" data-adc="">
                    <h3>Limão Siciliano</h3>
                </container>
            </div>
        </div>

        <div class="bloco-produtos">

            <div class="vitrine">
                <container class="produto-vitrine">
                    <img src="img/cake-slice-banoffee.png" class="rounded img-fluid" data-massa="Ba" data-recheio="03" data-adc="">
                    <h3 class="h3">Banoffee</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-frutas-vermelhas.png" class="rounded img-fluid" data-massa="Ba" data-recheio="09" data-adc="A4">
                    <h3 class="h3">Frutas Vermelhas</h3>
                </container>
            </div>

            <div class="vitrine">
                <container class="produto-vitrine">
                    <img src="img/cake-slice-floresta-negra.png" class="rounded img-fluid" data-massa="Ch" data-recheio="07" data-adc="">
                    <h3>Floresta Negra</h3>
                </container>

                <container class="produto-vitrine">
                    <img src="img/cake-slice-red-velvet.png" class="rounded img-fluid" data-massa="Re" data-recheio="06" data-adc="">
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
                <select class="custom-select my-1 mr-sm-2" id="tam_pedido" name="tam_pedido" required>
                    <option selected value="">Escolha um tamanho...</option>
                    <option value="Pe" <?php if($tam_pedido == 'Pe') echo 'selected'; ?>>Pequeno (700g)</option>
                    <option value="Me" <?php if($tam_pedido == 'Me') echo 'selected'; ?>>Médio (1,5kg)</option>
                    <option value="Gr" <?php if($tam_pedido == 'Gr') echo 'selected'; ?>>Grande (2kg)</option>
                    <option value="Su" <?php if($tam_pedido == 'Su') echo 'selected'; ?>>Super (3kg)</option>
                </select>

                <select class="custom-select my-1 mr-sm-2" id="massa_pedido" name="massa_pedido" required>
                    <option selected value="">Escolha uma massa...</option>
                    <option value="Ba" <?php if($massa_pedido == 'Ba') echo 'selected'; ?>>Baunilha</option>
                    <option value="Ch" <?php if($massa_pedido == 'Ch') echo 'selected'; ?>>Chocolate</option>
                    <option value="Re" <?php if($massa_pedido == 'Red Velvet') echo 'selected'; ?>>Red Velvet</option>
                </select>

                <select class="custom-select my-1 mr-sm-2" id="recheio_pedido" name="recheio_pedido" required>
                    <option selected value="">Escolha um recheio...</option>
                    <option value="01" <?php if($recheio_pedido == '01') echo 'selected'; ?>>Abacaxi em Calda</option>
                    <option value="02" <?php if($recheio_pedido == '02') echo 'selected'; ?>>Amendoim</option>
                    <option value="03" <?php if($recheio_pedido == '03') echo 'selected'; ?>>Banoffee</option>
                    <option value="04" <?php if($recheio_pedido == '04') echo 'selected'; ?>>Baunilha</option>
                    <option value="05" <?php if($recheio_pedido == '05') echo 'selected'; ?>>Brigadeiro</option>
                    <option value="06" <?php if($recheio_pedido == '06') echo 'selected'; ?>>Cream Cheese</option>
                    <option value="07" <?php if($recheio_pedido == '07') echo 'selected'; ?>>Creme de Avelã</option>
                    <option value="08" <?php if($recheio_pedido == '08') echo 'selected'; ?>>Coco</option>
                    <option value="09" <?php if($recheio_pedido == '09') echo 'selected'; ?>>Frutas vermelhas</option>
                    <option value="10" <?php if($recheio_pedido == '10') echo 'selected'; ?>>Limão Siciliano</option>
                    <option value="11" <?php if($recheio_pedido == '11') echo 'selected'; ?>>Leite em Pó</option>
                    <option value="12" <?php if($recheio_pedido == '12') echo 'selected'; ?>>Morango</option>
                </select>
                                
                <select class="custom-select my-1 mr-sm-2" id="adicional_pedido" name="adicional_pedido" required>
                    <option selected value="">Escolha um adicional...</option>
                    <option value="A0" <?php if($adicional_pedido == '00') echo 'selected'; ?>>Nenhum</option>
                    <option value="A1" <?php if($adicional_pedido == 'A1') echo 'selected'; ?>>Ferrero Rocher</option>
                    <option value="A2" <?php if($adicional_pedido == 'A2') echo 'selected'; ?>>Kit Kat</option>
                    <option value="A3" <?php if($adicional_pedido == 'A3') echo 'selected'; ?>>M&M</option>
                    <option value="A4" <?php if($adicional_pedido == 'A4') echo 'selected'; ?>>Morango</option>
                </select>

                <div class="form-group">
                    <input type="hidden" class="form-control" id="preco_total" readonly>
                </div>

                <input type="hidden" id="cod_bolo" name="cod_bolo">
                <input type="hidden" id="preco_final" name="preco_final">
                <input type="hidden" id="descricao" name="descricao">

                <input type="hidden" id="login_status" name="login_status" value="<?php echo $login_status ?>">

                <input type="text" class="form-control" id="txt_obs" name="txt_obs" placeholder="Observações ou comentários" value="<?php echo $obs; ?>">
                <input id="btn_pedir" type="submit" name="btn_pedir" placeholder="Adicionar no carrinho" class="btn btn_pedir btn-primary mb1 bg-fuchsia">
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