-- CRIANDO AS TABELAS
CREATE TABLE IF NOT EXISTS "Cidade" (
	"IdCidade"	INTEGER,
	"NomeCidade"	TEXT NOT NULL,
	PRIMARY KEY("IdCidade" AUTOINCREMENT)
);

CREATE TABLE "Adjacente" (
	"IdAdjacente"	INTEGER,
	"IdCidadeOrigem"	INTEGER,
	"IdCidadeDestino"	INTEGER,
	"DistRodEntreCidades"	INTEGER,
	FOREIGN KEY("IdCidadeDestino") REFERENCES "Cidade"("IdCidade"),
	FOREIGN KEY("IdCidadeOrigem") REFERENCES "Cidade"("IdCidade"),
	PRIMARY KEY("IdAdjacente" AUTOINCREMENT)
);

-- INSERINDO OS DADOS
INSERT INTO Cidade (NomeCidade) VALUES 
	('Votuporanga'), ('Valentim Gentil'), ('Meridiano'), ('Fernandópolis'),
	('Pedranópolis'), ('Parisi'), ('Alvores Florence'), ('Simonsen'), 
	('Américo de Campos'), ('Cosmorama'), ('Vila Nova'), ('Carvalho'), 
	('Cruzeiro'), ('Ecatu'), ('Tanabi'), ('Ibiporanga'), ('Palestina'), ('Ponte Gestal'),
	('Duplo Céu'), ('Boturuna'), ('Onda Branca'), ('Nova Granada'), ('Onda Verde'), 
	('Ipiguá'), ('Mirassolandia'), ('Balsamo'), ('Mirassol'), ('Eng. Balduino'), ('Monte Aprazivel'),
	('São José do Rio Preto'), ('Neves Paulista'), ('Jaci'), ('Ruilândia'), 
	('Rui Barbosa'), ('Peroba'), ('Santo Antonio das Perobas'), ('Nova Aliança'), ('Bady Bassitt'), 
	('Cedral'), ('Potirendaba'), ('Eng. Schimitt');
	
INSERT INTO Adjacente (IdCidadeOrigem, IdCidadeDestino, DistRodEntreCidades) VALUES 
(1, 2, 17), (1, 6, 16), (1, 7, 20), (1, 8, 10), (1,12,10),
(2, 1, 17), (2, 3, 21), (2, 12, 17),	
(3, 4, 15),	(3, 2, 21),
(4, 3, 15), (4, 5, 15),
(5, 6, 13), (5, 4, 15),
(6, 1, 16), (6, 5, 13), (6, 7, 11),
(7, 1, 20), (7, 6, 11), (7, 9, 20),
(8, 1, 10), (8, 9, 26), (8, 14, 22), (8, 11, 29),
(9, 7, 20), (9, 8, 26), (9, 11, 18), (9, 18, 18),
(10, 14, 13), (10, 11, 15),
(11, 9, 18), (11, 16, 20), (11, 10, 15), (11, 15, 29),
(12, 1, 10), (12, 13, 5),
(13, 12 , 5),
(14, 10, 13), (14, 15, 14),
(15, 11, 30), (15, 14, 14), (15, 16, 20), (15, 26, 16), (15, 28, 8),
(16, 17, 19), (16, 15, 20), (16, 11, 20),
(17, 16, 19), (17, 20, 16),(17, 21, 11),
(18, 9, 18), (18, 19, 22),
(19, 18, 22), (19, 20, 11),
(20, 19, 11), (20, 17, 16),
(21, 17, 11), (21, 22, 12),
(22, 21, 12), (22, 23, 11),
(23, 22, 11), (23, 24, 13), (23, 30, 24),
(24, 23, 13), (24, 25, 11), (24, 30, 14),
(25, 24, 11), (25, 26, 20),
(26, 15, 16), (26, 25, 20), (26, 27, 14),
(27, 26, 14), (27, 29, 25), (27, 30, 15), (27, 31, 17), (27, 32, 11), (27, 33, 14),
(28, 15, 8), (28, 29, 11),
(29, 28, 11), (29, 27, 25), (29, 31, 18),
(30, 23, 24), (30, 24, 14), (30, 27, 15), (30, 38, 17), (30, 34, 22), (30, 41, 10),
(31, 29, 18), (31, 32, 10), (31, 27, 17),
(32, 27, 11), (32, 31, 10), (32, 33, 7), (32, 35, 12),
(33, 32, 7), (33, 27, 11), (33, 34, 11),
(34, 33, 11), (34, 38, 12), (34, 30, 22), (34, 35, 6),
(35, 34, 6), (35, 36, 3),
(36, 35, 3), (36, 37, 10),
(37, 36, 10), (37, 38, 13), (37, 40, 15),
(38, 34, 12), (38, 37, 13), (38, 30, 17), (38, 40, 17),
(39, 41, 11), (39, 40, 22),
(40, 38, 17), (40, 37, 15), (40, 39, 15), 
(41, 30, 10), (41, 39, 11);