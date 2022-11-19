# AreaBiblioteca

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.


Create table Products(
Id int Primary key not null,
ProductName nvarchar(500) not null) /*Таблица продуктов*/

Create table Categories(
Id int Primary key not null,
CategoryName nvarchar(500) not null) /*Таблица категорий*/

Create table ProductsAndCategories(
Id int Primary key not null,
ProductsNameId int Foreign key references Products(Id),
CategoryNameId int Foreign key references Categories(Id)) /*Таблица связи продуктов и категорий*/

insert into Products values
	(1,'Мобилка_1'),
	(2,'Машинка'),
	(3,'Домик'),
	(4,'Верблюд'),
	(5,'Мобилка_2');

insert into Categories values
	(1,'Телефон'),
	(2,'Средства связи'),
	(3,'Автомобили'),
	(4,'Дома');

insert into ProductsAndCategories values
	(1,1,1),
	(2,1,2),
	(3,2,3),
	(4,3,4),	
	(5,5,1),
	(6,5,2);

select ProductName, CategoryName
from Products
left join ProductsAndCategories on Products.Id = ProductsAndCategories.ProductsNameId
left join Categories on ProductsAndCategories.CategoryNameId = Categories.Id 

![1](https://github.com/Presstomsk/Music_Downloader/blob/master/1.png)

