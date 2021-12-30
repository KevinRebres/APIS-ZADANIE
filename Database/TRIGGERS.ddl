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

