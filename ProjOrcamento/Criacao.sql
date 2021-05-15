

-- 1
create table Ambiente
(
	id_Ambiente int primary key identity,
	Descricao varchar(100)
)


-- 2
create table Squad
(
	id_Squad int primary key identity,
	Nome varchar(60),
	QtdPessoas int 
)

-- 3
create table Modulo 
(
	id_Modulo int primary key identity,
	id_Ambiente int, 
	id_Squad int

	CONSTRAINT FK_id_Ambiente_M FOREIGN KEY (id_Ambiente) REFERENCES Ambiente(id_Ambiente),
	CONSTRAINT FK_id_Squad_M FOREIGN KEY (id_Squad) REFERENCES Squad(id_Squad)

)

--4
create table Orcamento
(
	id_Orcamento int primary key identity,
	DtInicio varchar(30),
	DtFim varchar(30),
	QtdDias int,
	Descricao varchar(500),
	Titulo varchar(40),
	id_Modulo int

	CONSTRAINT FK_id_Modulo_O FOREIGN KEY (id_Modulo) REFERENCES Modulo(id_Modulo)
)



insert into Squad values ('ddd', 3)




insert into Modulo values(1, 1)