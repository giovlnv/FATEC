CREATE DATABASE cad_funcionario

USE cad_funcionario

CREATE TABLE tb_funcionario(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100),
	cpf VARCHAR(14),
	cargo VARCHAR(50),
	dtAdmissao DATE,
	qtdSalarios VARCHAR(10),
	salarioBruto VARCHAR(10),
	salarioLiquido VARCHAR(10),
	inss VARCHAR(10),
	foto VARCHAR(250)
)

SELECT * FROM tb_funcionario