CREATE TABLE Customers (
    Id INT AUTO_INCREMENT,
    Name TEXT,
    Address TEXT,
    PhoneNumber TEXT,
    CONSTRAINT CustomerId PRIMARY KEY(Id)
);

CREATE TABLE Products (
    Id INT AUTO_INCREMENT,
    Name TEXT,
    Quantity INT,
    Price FLOAT,
    CONSTRAINT ProductId PRIMARY KEY(Id)
);

CREATE TABLE Orders (
    Id INT AUTO_INCREMENT,
    Quantity INT,
    CustomerId INT,
    ProductId INT,
    CONSTRAINT OrderId PRIMARY KEY(Id),
    CONSTRAINT OrderCustomerId FOREIGN KEY(CustomerId)
    REFERENCES Customers(Id) ON DELETE CASCADE,
    CONSTRAINT OrderProductId FOREIGN KEY(ProductId)
    REFERENCES Products(Id) ON DELETE CASCADE
);
