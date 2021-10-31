using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OnAdoNetWinForms.DbQueryList
{
    public class SqlQueryList : IDbQueryList
    {

        public string InitTypes()
        {
            return @"CREATE TABLE ProductTypes(
[Id] int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
[Name] NVARCHAR(100) NOT NULL
);";
        }

        public string InitBuyers()
        {
            return @"CREATE TABLE Buyers(
[Id] int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
[Name] NVARCHAR(100) NOT NULL
);";
        }

        public string InitManagers()
        {
            return @"CREATE TABLE Managers(
[Id] int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
[FirstName] NVARCHAR(100) NOT NULL,
[LastName] NVARCHAR(100) NOT NULL
);";
        }

        public string InitProducts()
        {
            return @"CREATE TABLE Products(
[Id] int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
[Name] NVARCHAR(100) NOT NULL,
[TypeId] int NOT NULL FOREIGN KEY REFERENCES ProductTypes(Id)
);";
        }

        public string InitSales()
        {
            return @"CREATE TABLE Sales(
[Id] int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
[ProductId] int NOT NULL FOREIGN KEY REFERENCES Products(Id),
[ManagerId] int NOT NULL FOREIGN KEY REFERENCES Managers(Id),
[Quantity] int NOT NULL DEFAULT 1,
[Date] DATETIME NOT NULL DEFAULT GETDATE()
);";
        }

        public string ShowProducts()
        {
            return @"SELECT P.[Id], P.[Name], P.Price, PT.[Name] AS [Type] FROM Products AS P
JOIN ProductTypes AS PT ON P.TypeId = PT.Id;";
        }

        public string ShowTypes()
        {
            return @"SELECT [Name] AS [Type] FROM ProductTypes;";
        }

        public string ShowManagers()
        {
            return @"SELECT Id, FirstName, LastName FROM Managers;";
        }

        public string MaxSalesProducts()
        {
            return @"SELECT TOP 1 WITH TIES P.Id, P.[Name], P.Price FROM Products AS P
JOIN Sales AS S ON P.Id = S.ProductId
GROUP BY P.Id, P.[Name], P.Price
ORDER BY SUM(S.Quantity) DESC;";
        }

        public string MinSalesProducts()
        {
            return @"SELECT TOP 1 WITH TIES P.Id, P.[Name], P.Price FROM Products AS P
JOIN Sales AS S ON P.Id = S.ProductId
GROUP BY P.Id, P.[Name], P.Price
ORDER BY SUM(S.Quantity) ASC;";
        }

        public string MaxPriceProducts()
        {
            return @"SELECT TOP 1 WITH TIES Id, [Name], Price FROM Products
ORDER BY Price DESC;";
        }

        public string MinPriceProducts()
        {
            return @"SELECT TOP 1 WITH TIES Id, [Name], Price FROM Products
ORDER BY Price ASC;";
        }

        public string ShowRecentSale()
        {
            return @"SELECT TOP 1 WITH TIES S.[Id], S.[Date], P.[Name] AS [Product], S.Quantity, 
PT.[Name] AS [Type], M.[FirstName] + ' ' + M.[LastName] AS [ManagerFullName],
B.[Name] AS [BuyerName]
FROM Sales AS S
JOIN Products AS P ON S.[ProductId] = P.[Id]
JOIN ProductTypes AS PT ON P.[TypeId] = PT.[Id]
JOIN Managers AS M ON M.[Id] = S.[ManagerId]
JOIN Buyers AS B ON B.[Id] = S.[BuyerId]
ORDER BY S.[Date] DESC;";
        }

        public string ShowCountProductsType()
        {
            return @"SELECT PT.[Name], COUNT(P.Id) AS Products FROM ProductTypes AS PT
JOIN Products AS P ON PT.Id = P.TypeId
GROUP BY PT.[Name];";
        }

        public string ShowProductsByType()
        {
            return @"SELECT Products.Id, Products.[Name], Price, ProductTypes.[Name] AS [Type] FROM Products
JOIN ProductTypes ON ProductTypes.[Id] = Products.[TypeId]
WHERE ProductTypes.[Name] = @Type;";
        }

        public string ShowSalesByManager()
        {
            return @"SELECT Products.[Name] FROM Products
JOIN Sales ON Sales.[ProductId] = Products.Id
JOIN Managers ON Managers.[Id] = Sales.[ManagerId]
WHERE Managers.[FirstName] + ' ' + Managers.[LastName] = @ManagerName
GROUP BY Products.[Name];";
        }

        public string ShowSalesByBuyer()
        {
            return @"SELECT Products.[Name] FROM Products
JOIN Sales ON Sales.[ProductId] = Products.Id
JOIN Buyers ON Buyers.[Id] = Sales.[BuyerId]
WHERE Buyers.[Name] = @BuyerName
GROUP BY Products.[Name];";
        }
    }
}
