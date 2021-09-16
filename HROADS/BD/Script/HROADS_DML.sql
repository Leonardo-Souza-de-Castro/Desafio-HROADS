USE SENAI_HROADS_MANHA;


--Adicionando dados
INSERT INTO TiposHabilidades (TipoHabilidade)
VALUES ('Ataque'), ('Defesa'), ('Cura'), ('Magia')

SELECT * FROM TiposHabilidades


--Adicionando dados
INSERT INTO Habilidades (IdTipo,NomeHabilidade,DescricaoHabilidade)
VALUES (1,'Lança Mortal','Uma habilidade que consiste em um ataque muito forte em que são lançados mortais'), 
(2,'Escudo Supremo','Uma habilidade que consiste em uma defesa inabalável'),
(3,'Recuperar Vida','Uma habilidade que consiste em se curar ou curar seus aliados')

SELECT * FROM Habilidades



--Adicionando dados
INSERT INTO Classes (NomeClasse,DescricaoClasse,Vida,Mana)
VALUES ('Bárbaro','Os bárbaros são guerreiros tribais que entram em um estado de fúria que lhes garante força e resistência sem igual.',100,80), 
('Cruzado','Cruzados são  como fortalezas vivas, eles usam armaduras de placa "impenetráveis" e escudos imensos.',80,30),
('Caçadora de Demônios','Eles são treinados pela igreja, eles nascem com o objetivo de destruir demônios e seres com ligações Demoníacas.',95,85),
('Monge','Os monges buscam a perfeição espiritual através da meditação, e a perfeição corporal através de  artes marciais.',70,100),
('Necromante','Eles mantém contato com as almas e procuram modos para achar as respostas das lacunas sobre a vida após a morte.',60,70),
('Feiticeiro','Eles fazem feitiços e magias de forma empírica, para o bem ou para o mal.',85,100),
('Arcanista','São mágicos nada convencionais, esses guerreiros utilizam toda energia arcana canalizada em seus corpos para lutar.',75,60)

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
