CREATE PROCEDURE [dbo].[buscaNome]
	@nome varchar(50)
AS
	SELECT numeroCPF, nome, cep
	from Pessoa
	where nome like @nome + '%'