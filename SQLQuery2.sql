CREATE TABLE Users (
   UserId INT NOT NULL,
   FirstName VARCHAR(200) NULL,
   LastName VARCHAR(200) NULL,
   Email VARCHAR(200) NULL,
   Password VARCHAR(200) NULL,
   PRIMARY KEY (UserId));

INSERT INTO Users VALUES(1, 'Büşra', 'Yıldırım', 'b.yildirim@gmail.com', 'cinar5');
INSERT INTO Users VALUES(2, 'Ezgi', 'Doğdu', 'dogduezgi@gmail.com', 'aslı07');
INSERT INTO Users VALUES(3, 'Dilan', 'Kırmızı', 'kirmizi@gmail.com', 'red6');
INSERT INTO Users VALUES(4, 'Selin', 'Çolak', 'SelinÇ@gmail.com', '65432');
INSERT INTO Users VALUES(5, 'Ayşe', 'Oguz', 'ayse.o@gmail.com', '741963a');

select * from Users;

CREATE TABLE Customers (
   CustomerId INT NOT NULL,
   UserId INT NOT NULL,
   CompanyName VARCHAR(200) NULL,
   PRIMARY KEY (UserId),
   FOREIGN KEY (UserId) references Users(UserId));

INSERT INTO Customers VALUES(1, 1, 'Bulut  Rent A Car');
INSERT INTO Customers VALUES(2, 2, 'Topcu Oto Kiralama');
INSERT INTO Customers VALUES(3, 3, 'Erol Grup Oto Kiralama');

select * from Customers;


CREATE TABLE Rentals (
   RentalId INT NOT NULL,
   CarId INT NOT NULL,
   CustomerId INT NOT NULL,
   RentDate DATE NOT NULL,
   ReturnDate DATE NULL,
   PRIMARY KEY (RentalId),
   FOREIGN KEY (CustomerId) references Users(UserId),
   FOREIGN KEY (CarId) references Brands(BrandId));

INSERT INTO Rentals VALUES(1, 2, 3, '2021-01-15', '2021-01-20');
INSERT INTO Rentals VALUES(2, 1, 2, '2021-01-9', '2021-02-9');
INSERT INTO Rentals VALUES(3, 3, 3, '2021-06-20', '2021-06-23');

select * from Rentals;