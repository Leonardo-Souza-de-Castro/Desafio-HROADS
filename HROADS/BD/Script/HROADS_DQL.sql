USE SENAI_HROADS_MANHA;
GO

SELECT * FROM Personagens;
GO

SELECT * FROM Classes;
GO

SELECT NomeClasse
FROM Classes;
GO

SELECT * FROM Habilidades;
GO

SELECT IdHabilidade
FROM Habilidades
ORDER BY IdHabilidade ASC;
GO

SELECT * FROM TiposHabilidades;
GO

SELECT NomeHabilidade AS Habilidade, TipoHabilidade AS Tipo
FROM TiposHabilidades
RIGHT JOIN Habilidades
ON Habilidades.IdTipo = TiposHabilidades.IdTipo;
GO

SELECT NomePersonagem Personagem, NomeClasse Classe, Vida, Mana
FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse;
GO

SELECT NomeClasse Classe, NomeHabilidade Habilidades
FROM Classes
LEFT JOIN StatusPersonagens
ON Classes.IdClasse = StatusPersonagens.IdClasse
LEFT JOIN Habilidades
ON StatusPersonagens.IdHabilidade = Habilidades.IdHabilidade;
GO

SELECT NomeHabilidade Habilidades, NomeClasse Classe
FROM Classes
LEFT JOIN StatusPersonagens
ON Classes.IdClasse = StatusPersonagens.IdClasse
RIGHT JOIN Habilidades
ON StatusPersonagens.IdHabilidade = Habilidades.IdHabilidade;
GO

<<<<<<< HEAD
SELECT count(NomeHabilidade) 
FROM Habilidades;
=======
SELECT count(Nome_Habilidade) As [Quantidade de habilidades cadastradas]
FROM Habilidade;
>>>>>>> b179c73da902e9477d0ef3d059a138496406e87d
GO