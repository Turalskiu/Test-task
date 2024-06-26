CREATE TABLE Product
(
    Id INT IDENTITY(1,1),
    Title NVARCHAR(20) NOT NULL UNIQUE,

	PRIMARY KEY(Id)
);

CREATE TABLE Category
(
    Id INT IDENTITY(1,1),
    Title NVARCHAR(20) NOT NULL UNIQUE,

	PRIMARY KEY(Id)
);


CREATE TABLE ProductAndCategory
(
    ProductId INT NOT NULL,
	CategoryId INT NOT NULL,

	FOREIGN KEY (ProductId)  REFERENCES Product (Id) 
		ON DELETE CASCADE 
		ON UPDATE CASCADE,
	FOREIGN KEY (CategoryId)  REFERENCES Category (Id) 
		ON DELETE CASCADE 
		ON UPDATE CASCADE
);