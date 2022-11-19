Create table Products(
Id int Primary key not null, 
ProductName nvarchar(500) not null); /*������� ���������*/

Create table Categories( 
Id int Primary key not null, 
CategoryName nvarchar(500) not null); /*������� ���������*/

Create table ProductsAndCategories(
Id int Primary key not null,
ProductsNameId int Foreign key references Products(Id),
CategoryNameId int Foreign key references Categories(Id)); /*������� ����� ��������� � ���������*/

insert into Products values (1,'�������_1'), (2,'�������'), (3,'�����'), (4,'�������'), (5,'�������_2');

insert into Categories values (1,'�������'), (2,'�������� �����'), (3,'����������'), (4,'����');

insert into ProductsAndCategories values (1,1,1), (2,1,2), (3,2,3), (4,3,4), (5,5,1), (6,5,2);

select ProductName, CategoryName 
from Products 
left join ProductsAndCategories on Products.Id = ProductsAndCategories.ProductsNameId 
left join Categories on ProductsAndCategories.CategoryNameId = Categories.Id; /*��� JOIN*/ 