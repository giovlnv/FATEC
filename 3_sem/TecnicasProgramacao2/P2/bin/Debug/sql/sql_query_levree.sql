create database biblioteca_leevre;
use biblioteca_leevre;


create table tb_usuarios(
	cpf varchar(11) PRIMARY KEY NOT NULL,
	nome varchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	senha varchar(30) NOT NULL,
	dir_img varchar(500)
);


create table tb_livros(
	isbn varchar(13) primary key not null,
	titulo varchar(100) not null,
	autor varchar(50),
	serie varchar (20),
	editora varchar(50),
	idioma varchar(30),
	qtd_paginas int not null,
	qtd_total int not null,
	dt_publicacao date,
	flag_disponivel bit,
	qtd_disponivel int,
	dir_img varchar(500)
);

create table tb_emprestimos(
	id int IDENTITY(1,1) NOT NULL,
	isbn varchar(13) NOT NULL FOREIGN KEY REFERENCES tb_livros(isbn),
	titulo varchar(100),
	cpf varchar(11) foreign key references tb_usuarios(cpf),
	nome varchar(50),
	dt_emprestimo date not null,
	dt_previsao_devolucao date not null,
	dt_devolucao date
);

SELECT * FROM tb_livros;
