/* Una lista de todos los detalles de la tabla de empleados.*/ 
SELECT * From [Employees];
/* Una lista de los nombres y apellidos de todos los empleados. */
SELECT LastName, FirstName From [Employees];
--  Una lista de todos los nombres de las ciudades que aparecen en la tabla de empleados. 
-- No mostrar 2 veces un mismo nombre de ciudad. 
SELECT Distinct City From [Employees];
-- Una lista de los nombres de productos y precios unitarios 
SELECT ProductName, UnitPrice From [Products];
--  En la tabla de empleados: una lista de los detalles completos de los empleados que viven en EE.UU 
SELECT * From [Employees] Where Country = 'USA';
-- A partir de la tabla Pedidos, listar todos los pedidos que tienen un gasto de envió > 50.
SELECT * From [Orders] o Join [Order Details] od on o.OrderID = od.OrderID Where o.Freight > 50;
-- De la tabla de clientes: listar nombre de la empresa de todos los clientes donde el cargo es igual a Propietario.
SELECT c.CompanyName From [Customers] c Where c.ContactTitle = 'Owner';
-- A partir de los clientes una lista de todos donde el nombre del cliente comienza con la letra "A”. 
SELECT * From [Customers] c Where c.ContactName Like 'A%';
-- Una lista de los nombres de clientes donde la región no está en blanco
SELECT c.ContactName, c.Region From [Customers] c Where c.Region is NOT NULL;
-- Una lista de todos los productos, ordenado por precio unitario (el más barato primero)
SELECT p.ProductName, p.UnitPrice From [Products] p Order By p.UnitPrice;
--  Una lista de todos los productos, ordenado por precio unitario (el más caro primero). 
SELECT p.ProductName, p.UnitPrice From [Products] p Order By p.UnitPrice desc;
--  El número total de empleados. Nombre de la columna de salida "TotalEmpleados". 
SELECT COUNT (EmployeeID) as TotalEmpleados From [Employees] ;
--  De la tabla de Pedidos, el pedido con el menor gasto de envió, el gasto de envió promedio y el máximo gasto de envió 
-- (puede estar separado en 3 consultas distintas). 
SELECT MIN (Freight) From [Orders] o Join [Order Details] od on o.OrderID = od.OrderID 
SELECT AVG (Freight) From [Orders] o Join [Order Details] od on o.OrderID = od.OrderID 
SELECT MAX (Freight) From [Orders] o Join [Order Details] od on o.OrderID = od.OrderID 
--  Utilizando la tabla de clientes una lista de los nombres de ciudades y el número de clientes en cada ciudad. 
SELECT COUNT (c.CustomerID) as 'Cantidad de clientes', c.City From [Customers] c Group By City
-- Utilizando la tabla de clientes una lista de los nombres de ciudades y el número de clientes en cada ciudad. 
-- Solo las ciudades con al menos 2 clientes deben aparecer en la lista. 
SELECT COUNT (c.CustomerID) as 'Cantidad de clientes', c.City From [Customers] c Group By City having COUNT (c.CustomerID) > 2
--  Insertar el cliente nuevo completando todos los campos de la tabla. 
INSERT INTO [Customers] (CustomerID,CompanyName,ContactTitle) VALUES ('MDC','DelfisCompany','Delfina Caffa');
SELECT * From [Customers] Where CustomerID = 'MDC';
-- Actualizar el nombre del nuevo cliente pasando número de ID obtenido en el punto 16. 
UPDATE [Customers] Set CustomerID = 'DELF' WHERE CustomerID = 'MDC'
SELECT * From [Customers] Where CustomerID = 'DELF';
-- Eliminar el cliente insertado en el punto 16. 
DELETE FROM [Customers] Where CustomerID = 'DELF';