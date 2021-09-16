USE SENAI_HROADS_MANHA;


--Adicionando dados
INSERT INTO TiposHabilidades (TipoHabilidade)
VALUES ('Ataque'), ('Defesa'), ('Cura'), ('Magia')

SELECT * FROM TiposHabilidades


--Adicionando dados
INSERT INTO Habilidades (IdTipo,NomeHabilidade,DescricaoHabilidade)
VALUES (1,'Lan�a Mortal','Uma habilidade que consiste em um ataque muito forte em que s�o lan�ados mortais'), 
(2,'Escudo Supremo','Uma habilidade que consiste em uma defesa inabal�vel'),
(3,'Recuperar Vida','Uma habilidade que consiste em se curar ou curar seus aliados')

SELECT * FROM Habilidades



--Adicionando dados
INSERT INTO Classes (NomeClasse,DescricaoClasse,Vida,Mana)
VALUES ('B�rbaro','Os b�rbaros s�o guerreiros tribais que entram em um estado de f�ria que lhes garante for�a e resist�ncia sem igual.',100,80), 
('Cruzado','Cruzados s�o  como fortalezas vivas, eles usam armaduras de placa "impenetr�veis" e escudos imensos.',80,30),
('Ca�adora de Dem�nios','Eles s�o treinados pela igreja, eles nascem com o objetivo de destruir dem�nios e seres com liga��es Demon�acas.',95,85),
('Monge','Os monges buscam a perfei��o espiritual atrav�s da medita��o, e a perfei��o corporal atrav�s de  artes marciais.',70,100),
('Necromante','Eles mant�m contato com as almas e procuram modos para achar as respostas das lacunas sobre a vida ap�s a morte.',60,70),
('Feiticeiro','Eles fazem feiti�os e magias de forma emp�rica, para o bem ou para o mal.',85,100),
('Arcanista','S�o m�gicos nada convencionais, esses guerreiros utilizam toda energia arcana canalizada em seus corpos para lutar.',75,60)

SELECT * FROM Classes;
SELECT * FROM Habilidades;



--Adicionando dados
INSERT INTO StatusPersonagens(IdHabilidade,IdClasse)
VALUES (1,1),(2,1),(2,2),(1,3),(3,4),(2,4),(3,6)

SELECT * FROM StatusPersonagens




--Adicionando dados
INSERT INTO Personagens(IdClasse,NomePersonagem,DataCriacao,DataAtualizacao)
VALUES (1,'DeuBug','18/01/2019','10/08/2021'), (4,'BitBug','17/03/2016','10/08/2021'),(7,'Fer8','18/03/2018','10/08/2021')

SELECT * FROM Personagens



--Adicionando dados
INSERT INTO TiposUsuarios(Titulo)
VALUES ('Administrador'), ('Jogador')

SELECT * FROM TiposUsuarios



--Adicionando dados
INSERT INTO Usuarios(IdTipoUsuario, NomeUsuario, Email, Senha)
VALUES (1,'Administrador','adm@adm.com','admin'), (2,'Jogador','jogador@jogador.com','jogador')

SELECT * FROM Usuarios



--Selecionando todos os dados da tabela Habilidade
SELECT * FROM Habilidades
 
 --Selecionando todos os dados da tabela Classes
SELECT * FROM Classes

--Selecionando todos os dados da tabela StatusPersonagens
SELECT * FROM StatusPersonagens





UPDATE Personagens
SET NomePersonagem ='Fer7'
WHERE IdPersonagem = 3;

UPDATE Classes
SET Nome_Classe = 'Necromancer'
WHERE Id_Classe = 7;


UPDATE StatusPersonagens
SET IdClasse = 4
WHERE IdStatus = 7;
