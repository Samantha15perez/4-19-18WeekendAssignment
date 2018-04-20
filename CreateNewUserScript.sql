use adventureworks2012
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'AdvWorks2012')
BEGIN

CREATE LOGIN AdvWorks2012 WITH PASSWORD = '123456';

CREATE USER AdvWorks2012 FOR LOGIN AdvWorks2012; 
ALTER ROLE db_datareader ADD member AdvWorks2012; 
ALTER ROLE db_datawriter ADD member AdvWorks2012;

DENY DELETE ON SCHEMA::Person TO AdvWorks2012;
DENY INSERT ON SCHEMA::Person TO AdvWorks2012;
DENY UPDATE ON SCHEMA::Person TO AdvWorks2012;
DENY ALTER ON SCHEMA::Person TO AdvWorks2012;

DENY SELECT ON SCHEMA::HumanResources TO AdvWorks2012;
DENY UPDATE ON SCHEMA::HumanResources TO AdvWorks2012;
DENY INSERT ON SCHEMA::HumanResources TO AdvWorks2012;
DENY ALTER ON SCHEMA::HumanResources TO AdvWorks2012;
DENY DELETE ON SCHEMA::HumanResources TO AdvWorks2012;
END

go
create proc SalesOrderDetailsByCustomer (@Customerid int)
as
begin
Select SOH.SalesOrderID, OrderDate, ShipDate, CONCAT(P.Firstname, ' ', P.lastname) as SalesPerson, A.City, SP.Name as State, SOD.LineTotal from Sales.SalesOrderHeader SOH
inner join person.person P
on SOH.SalesPersonID = P.BusinessEntityID
inner join Sales.SalesOrderDetail SOD
on SOH.SalesOrderID = SOD.SalesOrderID
inner join person.Address A 
on A.AddressID = SOH.ShipToAddressID
inner join person.StateProvince SP
on SP.StateProvinceID = A.StateProvinceID
WHERE Customerid = @Customerid
end

go
create proc NameAndCustomerid
as
begin
Select Concat(Title, ' ', Firstname, ' ', lastname) as CustomerName, CustomerID from sales.customer C
inner join Person.Person P
on P.BusinessEntityID = C.PersonID
end

