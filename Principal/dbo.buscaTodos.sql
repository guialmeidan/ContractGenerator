CREATE PROCEDURE [dbo].[buscaTodos]
AS
	SELECT numeroCPF, nome, cep
	from Pessoa