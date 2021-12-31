INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Volkswagen", "Bratislava 811 03", "+421950828789");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("LandRover", "Zilina 010 01", "+421908569741");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Peugeot", "Trnava 917 01", "+421918841722");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Jaguar", "Michalovce 071 01", "+421908825589");
INSERT INTO Customers (Name, Address, PhoneNumber) VALUES ("Audi", "Kosice 040 01", "+421908068489");

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
