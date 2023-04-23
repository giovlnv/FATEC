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

var vitrineImagens = document.querySelectorAll('.vitrine img');
for (var i = 0; i < vitrineImagens.length; i++) {
  vitrineImagens[i].addEventListener('click', function() {
    var massa = this.getAttribute('data-massa');
    var recheio = this.getAttribute('data-recheio');
    document.getElementById('massa_pedido').value = massa ? massa : "Escolha uma massa...";
    document.getElementById('recheio_pedido').value = recheio ? recheio : "Escolha um recheio...";
    location.href = "#pedidos";
  });
}