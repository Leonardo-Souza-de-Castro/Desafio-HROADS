CREATE DATABASE SENAI_HROADS_MANHA;
GO

USE SENAI_HROADS_MANHA;
GO

CREATE TABLE Tipo_Habilidade(
    IdTipo INT PRIMARY KEY IDENTITY (1,1),
	Tipo_Habilidade VARCHAR(10) NOT NULL
);
GO

CREATE TABLE Habilidade(
    Id_Habilidade INT PRIMARY KEY IDENTITY (1,1),
	IdTipo INT FOREIGN KEY REFERENCES Tipo_Habilidade(IdTipo),
	Nome_Habilidade VARCHAR(25) NOT NULL UNIQUE,
	Descricao_Habilidade  VARCHAR(70) NOT NULL UNIQUE,
);
GO


CREATE TABLE Classe(
    Id_Classe INT PRIMARY KEY IDENTITY (1,1),
	Nome_Classe VARCHAR(20) NOT NULL UNIQUE,
	Descricao_Classe VARCHAR(70) NOT NULL UNIQUE,
	Vida TINYINT NOT NULL,
	Mana  TINYINT NOT NULL
);
GO

CREATE TABLE Status_Personagem(
   Id_Status INT PRIMARY KEY IDENTITY (1,1),
   Id_Habilidade INT FOREIGN KEY REFERENCES Habilidade(Id_Habilidade),
   IdClasse INT FOREIGN KEY REFERENCES Classe(Id_Classe)
);
GO

CREATE TABLE Personagens(
   IdPersonagem INT PRIMARY KEY IDENTITY (1,1),
   Id_Classe INT FOREIGN KEY REFERENCES Classe(Id_Classe),
   Nome_Personagem VARCHAR(30) NOT NULL UNIQUE,
   Data_Criacao DATE NOT NULL,
   Data_Atualizacao DATE NOT NULL
);
GO

ALTER TABLE Habilidade ALTER COLUMN Descricao_Habilidade VARCHAR (150);
GO

ALTER TABLE  Classe ALTER COLUMN Descricao_Classe VARCHAR (150);
GO