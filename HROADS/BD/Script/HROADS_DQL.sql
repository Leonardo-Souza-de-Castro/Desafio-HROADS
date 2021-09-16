USE SENAI_HROADS_MANHA;
GO

SELECT * FROM Personagens;
GO

SELECT * FROM Classe;
GO

SELECT Nome_Classe
FROM Classe;
GO

SELECT * FROM Habilidade;
GO

SELECT Id_Habilidade
FROM Habilidade
ORDER BY Id_Habilidade ASC;
GO

SELECT * FROM Tipo_Habilidade;
GO

SELECT Nome_Habilidade AS Habilidade, Tipo_Habilidade AS Tipo
FROM Tipo_Habilidade
RIGHT JOIN Habilidade
ON Habilidade.IdTipo = Tipo_Habilidade.IdTipo;
GO

SELECT Nome_Personagem Personagem, Nome_Classe Classe, Vida, Mana
FROM Personagens
INNER JOIN Classe
ON Personagens.Id_Classe = Classe.Id_Classe;
GO

SELECT Nome_Classe Classe, Nome_Habilidade Habilidades
FROM Classe
LEFT JOIN Status_Personagem
ON Classe.Id_Classe = Status_Personagem.IdClasse
LEFT JOIN Habilidade
ON Status_Personagem.Id_Habilidade = Habilidade.Id_Habilidade;
GO

SELECT Nome_Habilidade Habilidades, Nome_Classe Classe
FROM Classe
LEFT JOIN Status_Personagem
ON Classe.Id_Classe = Status_Personagem.IdClasse
RIGHT JOIN Habilidade
ON Status_Personagem.Id_Habilidade = Habilidade.Id_Habilidade;
GO

SELECT count(Nome_Habilidade) As [Quantidade de habilidades cadastradas]
FROM Habilidade;
GO