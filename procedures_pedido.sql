IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SelecionarPedido')
DROP PROCEDURE SelecionarPedido
GO

CREATE PROCEDURE SelecionarPedido
	@idCliente varchar(256) = NULL,
	@idProduto varchar(256) = NULL
AS 
BEGIN 

	/*
		Documenta��o:
		Arquivo: procedures_pedido
		Descri��o: Seleciona pedidos por id
		Autor: Bruno Barbosa
		EXEC SelecionarPedido 1
	*/

	SELECT	idCliente,
			idProduto,
			quantidade
		FROM Pedido WITH(NOLOCK)
		WHERE (@idCliente IS NULL OR idCliente = @idCliente)
			AND (@idProduto IS NULL OR idProduto = @idProduto)
END 