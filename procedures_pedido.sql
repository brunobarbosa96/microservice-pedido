IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SelecionarPedido')
DROP PROCEDURE SelecionarPedido
GO

CREATE PROCEDURE SelecionarPedido
	@idCliente varchar(256) = NULL,
	@idProduto varchar(256) = NULL
AS 
BEGIN 

	/*
		Documentação:
		Arquivo: procedures_pedido
		Descrição: Seleciona pedidos por id
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