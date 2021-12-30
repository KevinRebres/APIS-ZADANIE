DROP TABLE Orders;
DROP TABLE Customers;
DROP TABLE Products;

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



delimiter |
CREATE OR REPLACE TRIGGER OrderInsertQuantityTrigger
BEFORE INSERT ON Orders FOR EACH ROW
BEGIN 
  UPDATE Products SET Products.Quantity = Products.Quantity - NEW.Quantity
  WHERE Products.Id = NEW.ProductId; 
END;
| delimiter ;

delimiter |
CREATE OR REPLACE TRIGGER OrderUpdateQuantityTrigger
BEFORE UPDATE ON Orders FOR EACH ROW
BEGIN 
  UPDATE Products SET Products.Quantity = Products.Quantity + OLD.Quantity
  WHERE Products.Id = NEW.ProductId; 
  UPDATE Products SET Products.Quantity = Products.Quantity - NEW.Quantity
  WHERE Products.Id = NEW.ProductId; 
END;
| delimiter ;

delimiter |
CREATE OR REPLACE TRIGGER OrderDeleteQuantityTrigger
BEFORE DELETE ON Orders FOR EACH ROW
BEGIN 
  UPDATE Products SET Products.Quantity = Products.Quantity + OLD.Quantity
  WHERE Products.Id = OLD.ProductId; 
END;
| delimiter ;

INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Volkswagen", "Bratislava 811 03", "+421950828789");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("LandRover", "Žilina 010 01", "+421908569741");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Peugeot", "Trnava 917 01", "+421918841722");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Jaguar", "Michalovce 071 01", "+421908825589");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Audi", "Košice 040 01", "+421908068489");

INSERT INTO Products (Name, Quantity, Price) VALUES ("Diesel Engine", 17, 999.99);
INSERT INTO Products (Name, Quantity, Price) VALUES ("Manual Gearbox", 25, 559.99);
INSERT INTO Products (Name, Quantity, Price) VALUES ("Accumulator", 8, 79.99);
INSERT INTO Products (Name, Quantity, Price) VALUES ("Oil Filter", 33, 21.99);
INSERT INTO Products (Name, Quantity, Price) VALUES ("Autoradio", 9, 75.99);

INSERT INTO Orders (Quantity, CustomerId, ProductId) VALUES (3, 2, 1);
INSERT INTO Orders (Quantity, CustomerId, ProductId) VALUES (5, 1, 3);
INSERT INTO Orders (Quantity, CustomerId, ProductId) VALUES (2, 3, 2);
INSERT INTO Orders (Quantity, CustomerId, ProductId) VALUES (3, 4, 5);
INSERT INTO Orders (Quantity, CustomerId, ProductId) VALUES (1, 5, 4);
