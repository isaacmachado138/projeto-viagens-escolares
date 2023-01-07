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
                VALUES('Sebastião Bento Martin da Luz','98204795688', 'sebastiao-daluz95@gtx.ag', '14/08/1997', 'Rua Santa Inês', 'Passos', 'Centro', 'Ap','35983413989', 'SI', 'al'), 
                ('Henrique Mário Iago Teixeira','51841204676', 'henrique_teixeira@multieventos.art.br', '08/02/2001', 'Rua dos Engenheiros', 'Passos', 'Belo Horizonte', 'Ap','35996865468', 'SI', 'pr'),
                ('Daniela Débora Antonella Farias','69136868620', 'daniela-farias77@jarretta.com', '18/05/1999', 'Rua do Lampião', 'Passos', 'Centro', 'Ap','35989311422', 'SI', 'pr'),
                ('Isabelly Alessandra Nina da Rocha','83257357672', 'isabelly.alessandra.darocha@agrosb.com.br', '15/02/1998', 'Rua Sálvio Pereira Lima', 'Passos', 'Centro', 'Ap','35981073217', 'SI', 'al'), 
                ('Nathan Joaquim Yago das Neves','83657367878', 'carlos@gmail.com', '10/12/2022', 'Rua dos Bobos', 'Passos', 'Centro', 'Ap','35997122312', 'SI', 'al');

SELECT * FROM participantes