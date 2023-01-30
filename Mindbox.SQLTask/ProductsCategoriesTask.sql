CREATE DATABASE Mindbox
GO

USE Mindbox
GO

CREATE TABLE Products
(
    ProductId INT IDENTITY(1,1),
    ProductName NVARCHAR(200)
    PRIMARY KEY (ProductID)
)

CREATE TABLE Categories
(
    CategoryId INT IDENTITY(1,1),
    CategoryName NVARCHAR(200)
    PRIMARY KEY (CategoryId)
)

CREATE TABLE ProductsCategories
(
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
)

INSERT INTO Products
(ProductName)
VALUES
('Подсолнечное масло'),
('Сыр'),
('Стол'),
('Macbook')

INSERT INTO Categories
(CategoryName)
VALUES
('Пищевая продукция'),
('Молочная продукция'),
('Мебель')

insert into ProductsCategories
(ProductId, CategoryId)
VALUES
(1, 1),
(2, 1),
(2, 2),
(3, 3)

SELECT ProductName, ISNULL(CategoryName, '') as CategoryName FROM Products prod
LEFT JOIN ProductsCategories prodCat ON prod.ProductId = prodCat.ProductId
LEFT JOIN Categories C ON prodCat.CategoryId = C.CategoryId
