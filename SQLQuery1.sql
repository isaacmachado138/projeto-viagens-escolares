CREATE DATABASE Projeto;
USE Projeto;


CREATE TABLE [dbo].[participantes] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (150) NOT NULL,
    [cpf]         VARCHAR (12) NOT NULL,
    [email]       VARCHAR (150) NULL,
    [nasc]        DATE         NOT NULL,
    [endereco]       VARCHAR (150) NULL,
    [municipio]   VARCHAR (150) NOT NULL,
    [bairro]      VARCHAR (150) NOT NULL,
    [complemento] VARCHAR (150) NULL,
    [telefone]    VARCHAR (12) NULL,
	curso VARCHAR(150) NOT NULL,
	funcao CHAR(2) NOT NULL CHECK (funcao in ('AL', 'PR'))
);


CREATE TABLE visitas (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    saida        DATETIME         NOT NULL,
    chegada      DATETIME         NOT NULL,
    origem       VARCHAR (150) NULL,
    destino      VARCHAR (150) NULL,
    curso        VARCHAR(150) NOT NULL,
);

CREATE TABLE part_visitas(
id_participante INT NOT NULL,
id_visita INT NOT NULL
);

INSERT INTO dbo.participantes (name, cpf, email, nasc, endereco ,municipio, bairro, complemento, telefone, curso, funcao)
                VALUES('Joao','12213212312', 'joao@gmail.com', '10/12/2022', 'Rua dos Bobos', 'Passos', 'Centro', 'Ap','19997122312', 'SI', 'al'), 
                ('Joao','12213214442', 'joaoaaa@gmail.com', '10/12/2022', 'Rua dos Bobos', 'Passos', 'Centro', 'Ap','19997122312', 'SI', 'pr'),
                ('Joao','12219994442', 'joaoafd12aa@gmail.com', '10/01/2022', 'Rua dos Bobos', 'Passos', 'Centro', 'Ap','19997994312', 'SI', 'pr');

INSERT INTO dbo.participantes (name, cpf, email, nasc, endereco ,municipio, bairro, complemento, telefone, curso, funcao)
                VALUES('Maria','12233212312', 'maria@gmail.com', '10/12/2022', 'Rua dos Bobos', 'Passos', 'Centro', 'Ap','19997122312', 'SI', 'al'), 
                ('Carlos','12213779142', 'carlos@gmail.com', '10/12/2022', 'Rua dos Bobos', 'Passos', 'Centro', 'Ap','19997122312', 'SI', 'al');

SELECT * FROM part_visitas