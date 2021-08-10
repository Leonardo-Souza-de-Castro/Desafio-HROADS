USE SENAI_HROADS_MANHA;

INSERT INTO Tipo_Habilidade (Tipo_Habilidade)
VALUES ('Ataque'), ('Defesa'), ('Cura'), ('Magia')

SELECT * FROM Tipo_Habilidade

INSERT INTO Habilidade (IdTipo,Nome_Habilidade,Descricao_Habilidade)
VALUES (1,'Lança Mortal','Uma habilidade que consiste em um ataque muito forte em que são lançados mortais'), 
(2,'Escudo Supremo','Uma habilidade que consiste em uma defesa inabalável'),
(3,'Recuperar Vida','Uma habilidade que consiste em se curar ou curar seus aliados')

INSERT INTO Classe (Nome_Classe,Descricao_Classe,Vida,Mana)
VALUES ('Bárbaro','Os bárbaros são guerreiros tribais que entram em um estado de fúria que lhes garante força e resistência sem igual.',100,80), 
('Cruzado','Cruzados são  como fortalezas vivas, eles usam armaduras de placa "impenetráveis" e escudos imensos.',80,30),
('Caçadora de Demônios','Eles são treinados pela igreja, eles nascem com o objetivo de destruir demônios e seres com ligações Demoníacas.',95,85),
('Monge','Os monges buscam a perfeição espiritual através da meditação, e a perfeição corporal através de  artes marciais.',70,100),
('Necromante','Eles mantém contato com as almas e procuram modos para achar as respostas das lacunas sobre a vida após a morte.',60,70),
('Feiticeiro','Eles fazem feitiços e magias de forma empírica, para o bem ou para o mal.',85,100),
('Arcanista','São mágicos nada convencionais, esses guerreiros utilizam toda energia arcana canalizada em seus corpos para lutar.',75,60)

INSERT INTO Status_Personagem(Id_Habilidade,IdClasse)
VALUES (10,3),(10,3),(9,5),(11,6),(10,6),(11,8)

SELECT * FROM Habilidade
 
SELECT * FROM Classe

SELECT * FROM Status_Personagem

INSERT INTO Personagens(Id_Classe,Nome_Personagem,Data_Criacao,Data_Atualizacao)
VALUES (3,'DeuBug','18/01/2019','10/08/2021'), (6,'BitBug','17/03/2016','10/08/2021'),(9,'Fer8','18/03/2018','10/08/2021')

SELECT * FROM Personagens

UPDATE Personagens
SET Nome_Personagem ='Fer7'
WHERE IdPersonagem = 3;

UPDATE Classe
SET Nome_Classe = 'Necromancer'
WHERE Id_Classe = 7;