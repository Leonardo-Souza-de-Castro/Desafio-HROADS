USE SENAI_HROADS_MANHA;

INSERT INTO Tipo_Habilidade (Tipo_Habilidade)
VALUES ('Ataque'), ('Defesa'), ('Cura'), ('Magia')

SELECT * FROM Tipo_Habilidade

INSERT INTO Habilidade (IdTipo,Nome_Habilidade,Descricao_Habilidade)
VALUES (1,'Lan�a Mortal','Uma habilidade que consiste em um ataque muito forte em que s�o lan�ados mortais'), 
(2,'Escudo Supremo','Uma habilidade que consiste em uma defesa inabal�vel'),
(3,'Recuperar Vida','Uma habilidade que consiste em se curar ou curar seus aliados')

INSERT INTO Classe (Nome_Classe,Descricao_Classe,Vida,Mana)
VALUES ('B�rbaro','Os b�rbaros s�o guerreiros tribais que entram em um estado de f�ria que lhes garante for�a e resist�ncia sem igual.',100,80), 
('Cruzado','Cruzados s�o  como fortalezas vivas, eles usam armaduras de placa "impenetr�veis" e escudos imensos.',80,30),
('Ca�adora de Dem�nios','Eles s�o treinados pela igreja, eles nascem com o objetivo de destruir dem�nios e seres com liga��es Demon�acas.',95,85),
('Monge','Os monges buscam a perfei��o espiritual atrav�s da medita��o, e a perfei��o corporal atrav�s de  artes marciais.',70,100),
('Necromante','Eles mant�m contato com as almas e procuram modos para achar as respostas das lacunas sobre a vida ap�s a morte.',60,70),
('Feiticeiro','Eles fazem feiti�os e magias de forma emp�rica, para o bem ou para o mal.',85,100),
('Arcanista','S�o m�gicos nada convencionais, esses guerreiros utilizam toda energia arcana canalizada em seus corpos para lutar.',75,60)

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