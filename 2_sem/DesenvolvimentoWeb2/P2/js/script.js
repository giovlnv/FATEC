let navbar = document.querySelector('.header .navbar');
let menu = document.querySelector('#menu-btn');

menu.onclick = () =>{
    navbar.classList.toggle('menuAberto');
}

document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("btn_logout").addEventListener("click", function() {
    window.location.href = "php/logout.php";
  });
});

document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("btn_logout_sub").addEventListener("click", function() {
    window.location.href = "logout.php";
  });
});


document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("btn_login").addEventListener("click", function() {
    window.location.href = "php/login.php";
  });
});

document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("btn_login_sub").addEventListener("click", function() {
    window.location.href = "login.php";
  });
});


document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("btn_carrinho").addEventListener("click", function() {
    window.location.href = "php/carrinho.php";
  });
});

document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("btn_carrinho_sub").addEventListener("click", function() {
    window.location.href = "carrinho.php";
  });
});


document.addEventListener("DOMContentLoaded", function() {
  var botao = document.getElementById("btn_pedir");
  if (botao) {
    botao.addEventListener("click", function(event) {
      var login_status = document.getElementById("login_status").value;
      event.preventDefault();
      var form = document.querySelector('form[name="frm_pedidos"]');
      if (form) {
        var camposPreenchidos = true;
        var camposRequeridos = form.querySelectorAll('[required]');
        camposRequeridos.forEach(function(campo) {
          if (!campo.value) {
            camposPreenchidos = false;
          }
        });

        if (camposPreenchidos) {
          if (login_status === 'logado') {
            form.action = "php/adicionar_carrinho.php";
          } else {
            form.action = "php/login.php";
          }
          form.submit();
        } else {
          alert("Por favor, preencha todos os campos requeridos.");
        }
      }
    });
  }
});




var vitrineImagens = document.querySelectorAll('.vitrine img');
for (var i = 0; i < vitrineImagens.length; i++) {
  vitrineImagens[i].addEventListener('click', function() {
    var massa = this.getAttribute('data-massa');
    var recheio = this.getAttribute('data-recheio');
    var adic = this.getAttribute('data-adc');
    document.getElementById('massa_pedido').value = massa ? massa : "Escolha uma massa...";
    document.getElementById('recheio_pedido').value = recheio ? recheio : "Escolha um recheio...";
    document.getElementById('adicional_pedido').value = adic ? adic : "";

    if (!adic) {
      document.getElementById('adicional_pedido').selectedIndex = 0; 
    }    

    location.href = "#pedidos";
    obterCaracteristicasSelecionadas();
    
  });
}



// CRIAÇÃO DO BOLO

class Caracteristica {
  constructor(nome, preco, cod) {
    this.nome = nome;
    this.preco = preco;
    this.cod = cod;
  }
}

class Bolo {
  constructor(massa, tamanho, recheio, adicional) {
    this.massa = massa;
    this.tamanho = tamanho;
    this.recheio = recheio;
    this.adicional = adicional;
  }

  calcularPrecoTotal() {
    let precoTotal = 0;
    precoTotal += this.massa.preco;
    precoTotal += this.tamanho.preco;
    precoTotal += this.recheio.preco;
    precoTotal += this.adicional.preco;
    return precoTotal;
  }

}

function obterCaracteristicasSelecionadas() {
  // Início das características
  // Preços
  const precoMassaBaunilha = 0;
  const precoMassaChocolate = 0;
  const precoMassaRedVelvet = 2;
  const precoTamanhoPequeno = 15;
  const precoTamanhoMedio = 20;
  const precoTamanhoGrande = 25;
  const precoTamanhoSuper = 30;
  const precoRecheioAbacaxi = 5;
  const precoRecheioAmendoim = 0;
  const precoRecheioBanoffee = 5;
  const precoRecheioBaunilha = 0;
  const precoRecheioBrigadeiro = 0;
  const precoRecheioCreamCheese = 5;
  const precoRecheioCremeAvela = 5;
  const precoRecheioCoco = 0;
  const precoRecheioFrutasVermelhas = 5;
  const precoRecheioLimaoSiciliano = 5;
  const precoRecheioLeitePo = 0;
  const precoRecheioMorango = 5;
  const precoAdicionalNenhum = 0;
  const precoAdicionalFerreroRocher = 3;
  const precoAdicionalKitKat = 3;
  const precoAdicionalMnMs = 3;
  const precoAdicionalMorango = 3;

  // Massa
  const massaSelected = document.getElementById("massa_pedido").value;

  let precoMassa = 0;
  let codMassa = '';

  if (massaSelected === 'Ba') {
    precoMassa = precoMassaBaunilha;
    codMassa = 'Baunilha';
  } else if (massaSelected === 'Ch') {
    precoMassa = precoMassaChocolate;
    codMassa = 'Chocolate';
  } else if (massaSelected === 'Re') {
    precoMassa = precoMassaRedVelvet;
    codMassa = 'Red Velvet';
  }

  const massa = new Caracteristica(massaSelected, precoMassa, codMassa);

  // Tamanho
  const tamSelected = document.getElementById("tam_pedido").value;

  let precoTamanho = 0;
  let codTamanho = '';

  if (tamSelected === 'Pe') {
    precoTamanho = precoTamanhoPequeno;
    codTamanho = 'Pequeno';
  } else if (tamSelected === 'Me') {
    precoTamanho = precoTamanhoMedio;
    codTamanho = 'Medio';
  } else if (tamSelected === 'Gr') {
    precoTamanho = precoTamanhoGrande;
    codTamanho = 'Grande';
  } else if (tamSelected === 'Su') {
    precoTamanho = precoTamanhoSuper;
    codTamanho = 'Super';
  }

  const tamanho = new Caracteristica(tamSelected, precoTamanho, codTamanho);

  // Recheio
  const recheioSelected = document.getElementById("recheio_pedido").value;

  let precoRecheio = 0;
  let codRecheio = '';

  if (recheioSelected === '01') {
    precoRecheio = precoRecheioAbacaxi;
    codRecheio = 'Abacaxi em Calda';
  } else if (recheioSelected === '02') {
    precoRecheio = precoRecheioAmendoim;
    codRecheio = 'Amendoim';
  } else if (recheioSelected === '03') {
    precoRecheio = precoRecheioBanoffee;
    codRecheio = 'Banoffee';
  } else if (recheioSelected === '04') {
    precoRecheio = precoRecheioBaunilha;
    codRecheio = 'Baunilha';
  } else if (recheioSelected === '05') {
    precoRecheio = precoRecheioBrigadeiro;
    codRecheio = 'Brigadeiro';
  } else if (recheioSelected === '06') {
    precoRecheio = precoRecheioCreamCheese;
    codRecheio = 'Cream Cheese';
  } else if (recheioSelected === '07') {
    precoRecheio = precoRecheioCremeAvela;
    codRecheio = 'Creme de Avela';
  } else if (recheioSelected === '08') {
    precoRecheio = precoRecheioCoco;
    codRecheio = 'Coco';
  } else if (recheioSelected === '09') {
    precoRecheio = precoRecheioFrutasVermelhas;
    codRecheio = 'Frutas Vermelhas';
  } else if (recheioSelected === '10') {
    precoRecheio = precoRecheioLimaoSiciliano;
    codRecheio = 'Limao Siciliano';
  } else if (recheioSelected === '11') {
    precoRecheio = precoRecheioLeitePo;
    codRecheio = 'Leite em Po';
  } else if (recheioSelected === '12') {
    precoRecheio = precoRecheioMorango;
    codRecheio = 'Morango';
  }

  const recheio = new Caracteristica(recheioSelected, precoRecheio, codRecheio);

  // Adicionais
  const adicionalSelected = document.getElementById("adicional_pedido").value;

  let precoAdicional = 0;
  let codAdicional = '';

  if (adicionalSelected === 'A0') {
    precoAdicional = precoAdicionalNenhum;
    codAdicional = 'Nenhum';
  } else if (adicionalSelected === 'A1') {
    precoAdicional = precoAdicionalFerreroRocher;
    codAdicional = 'Ferrero Rocher';
  } else if (adicionalSelected === 'A2') {
    precoAdicional = precoAdicionalKitKat;
    codAdicional = 'Kit Kat';
  } else if (adicionalSelected === 'A3') {
    precoAdicional = precoAdicionalMnMs;
    codAdicional = 'M&Ms';
  } else if (adicionalSelected === 'A4') {
    precoAdicional = precoAdicionalMorango;
    codAdicional = 'Morango';
  }

  const adicional = new Caracteristica(adicionalSelected, precoAdicional, codAdicional);

  // Fim das características

  const boloSelecionado = new Bolo(massa, tamanho, recheio, adicional);
  const precoTotalBolo = boloSelecionado.calcularPrecoTotal();
  document.getElementById("preco_total").value = precoTotalBolo.toFixed(2);
  document.getElementById("preco_final").value = precoTotalBolo.toFixed(2);
  document.getElementById("btn_pedir").value ="Adicionar ao carrinho ㅤㅤ(R$ " + precoTotalBolo.toFixed(2)+ ")";

  const codigoBolo = tamSelected + recheioSelected + massaSelected + adicionalSelected;
  document.getElementById("cod_bolo").value = codigoBolo;

  document.getElementById("descricao").value = 'Bolo ' + codTamanho + ' com massa sabor ' + codMassa + ', recheio sabor ' + codRecheio + '. Adicional: ' + codAdicional;
}

const form = document.forms.frm_pedidos;
form.addEventListener('submit', function (event) {
  event.preventDefault();
  obterCaracteristicasSelecionadas();
});

document.getElementById("massa_pedido").addEventListener("change", obterCaracteristicasSelecionadas);
document.getElementById("tam_pedido").addEventListener("change", obterCaracteristicasSelecionadas);
document.getElementById("recheio_pedido").addEventListener("change", obterCaracteristicasSelecionadas);
document.getElementById("adicional_pedido").addEventListener("change", obterCaracteristicasSelecionadas);

// END CRIAÇÃO DO BOLO