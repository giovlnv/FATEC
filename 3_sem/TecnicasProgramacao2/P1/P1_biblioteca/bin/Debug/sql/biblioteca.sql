CREATE DATABASE p1_biblio

USE p1_biblio

CREATE TABLE tb_livro(
	id INT IDENTITY(1,1),
	isbn VARCHAR(17) PRIMARY KEY,
	titulo VARCHAR(250),
	autor VARCHAR(250),
	editora VARCHAR(250),
	paginas INT,
	dt_pub DATE,
	idioma VARCHAR(250),
	serie VARCHAR(250) NULL,
	ds_status VARCHAR(250) NULL,
	quant INT NULL,
	capa VARCHAR(250)
)

CREATE TABLE tb_usuario(
	id INT IDENTITY(1,1),
	nome VARCHAR(250),
	cpf VARCHAR(14) PRIMARY KEY,
	email VARCHAR(250),
	senha VARCHAR(50),
	saldo VARCHAR(10) NULL,
	foto varchar (250)
)

CREATE TABLE tb_emprestimo(
	id INT IDENTITY(1567,1) PRIMARY KEY,
	isbn VARCHAR(17),
	cpf VARCHAR(14),
	dt_emprestimo DATE NOT NULL,
	dt_devol DATE NULL,
	dt_prev DATE NOT NULL
	FOREIGN KEY (cpf) REFERENCES tb_usuario(cpf),
	FOREIGN KEY (isbn) REFERENCES tb_livro(isbn)
)

SELECT * FROM tb_livro

SELECT * FROM tb_usuario

SELECT * FROM tb_emprestimo