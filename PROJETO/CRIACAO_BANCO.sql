

create table TB_AlunosDiplomados
(
	Id_aluno int primary key identity,
	NOME varchar(50),	
	CPF	varchar(20),
	EMEC_CURSO	varchar(30),
	CURSO varchar(50),
	ANO_INGRESSO varchar(4), 	
	SEMESTRE_INGRESSO varchar(30),
	DATA_EXPEDICAO_DIPLOMA varchar(20),	
	DATA_REGISTRO_DIPLOMA varchar(20),
	NUMERO_REGISTRO_DIPLOMA	varchar(20),
	DATA_PUBLICACAO_DOU	varchar(30),
	EMEC_IES_EXPEDIDORA	varchar(40),
	EMEC_IES_REGISTRADORA varchar(30)
)

--insert into TB_AlunosDiplomados (NOME) values ('VINICIUS')

SELECT * FROM TB_AlunosDiplomados with(nolock)

delete from TB_AlunosDiplomados



