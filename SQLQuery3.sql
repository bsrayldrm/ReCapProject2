CREATE TABLE Customers (
CustomerId INT NOT NULL,
UserId INT NOT NULL,
CompanyName VARCHAR(200) NULL,
PRIMARY KEY (CustomerId),
FOREIGN KEY (UserId) references Users(UserId));

select*from Customers;
select*from Users;