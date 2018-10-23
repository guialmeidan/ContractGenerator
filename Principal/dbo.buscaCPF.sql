CREATE PROCEDURE [dbo].[buscaCPF]
	@CPF varchar(11)
AS
	SELECT numeroCPF, nome, cep
	from Pessoa
	where numeroCPF = @CPF