USE "microservice-produto"

CREATE TABLE Produto (
		id int primary key identity(1,1),
		nome varchar(50),
		preco decimal(15,2)
	)

INSERT INTO Produto (nome, preco)
	VALUES ('Garafa de água', 2.00),
		   ('Caneca', 50.00),
		   ('Chocolate', 5.00),
		   ('Vibrador', 100.00),
		   ('Toca fita', 250.00),
		   ('Vitrola', 310.00),
		   ('Asinha de frango', 12.00),
		   ('Adaptador de supositório', 15.25),
		   ('Teclado e mouse', 89.90),
		   ('Um bom livro', 150.99)
