CREATE DATABASE locadora_carros;
GO

USE locadora_carros;
GO

CREATE TABLE tb_contas (
    id INT IDENTITY(1,1) PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(50) NOT NULL,
    tipo VARCHAR(10) NOT NULL,
    email VARCHAR(100),
    status VARCHAR(10) DEFAULT 'Ativo'
);
GO

INSERT INTO tb_contas (usuario, senha, tipo, email, status) VALUES ('admin', '1234', 'ADM', 'admin@locadora.com', 'Ativo');
GO

CREATE TABLE tb_clientes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    cpf VARCHAR(14) NOT NULL UNIQUE,
    nome VARCHAR(100) NOT NULL,
    fone VARCHAR(20),
    email VARCHAR(100),
    endereco VARCHAR(200)
);
GO

CREATE TABLE tb_carros (
    id INT IDENTITY(1,1) PRIMARY KEY,
    placa VARCHAR(10) NOT NULL UNIQUE,
    modelo VARCHAR(100) NOT NULL,
    marca VARCHAR(50),
    ano INT,
    cor VARCHAR(30),
    valor_diaria DECIMAL(10,2) NOT NULL,
    disponivel BIT DEFAULT 1
);
GO

CREATE TABLE tb_locacoes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_carro INT NOT NULL,
    data_saida DATE NOT NULL,
    data_prevista DATE NOT NULL,
    data_retorno DATE,
    valor_total DECIMAL(10,2),
    status VARCHAR(20) DEFAULT 'Aberta',
    FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id),
    FOREIGN KEY (id_carro) REFERENCES tb_carros(id)
);
GO
