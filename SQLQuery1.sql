CREATE TABLE Colors(
ColorId int PRIMARY KEY IDENTITY (1,1),
ColorName nvarchar (25)
)
CREATE TABLE Brands(
BrandId int PRIMARY KEY IDENTITY (1,1),
BrandName nvarchar (25)
)
CREATE TABLE Cars(
Id int  PRIMARY KEY IDENTITY (1,1),
BrandId int,
ColorId int,
ModelYear nvarchar(25),
DailyPrice decimal,
Descriptions nvarchar(25),
FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
FOREIGN KEY (ColorId) REFERENCES Colors(colorId)

)
INSERT INTO Colors(ColorName)
VALUES
('Füme'),
('Kırmızı'),
('Siyah');

INSERT INTO Brands(BrandName)
VALUES
('Audi'),
('Fiat'),
('BMW'),
('Renault');



INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
('1', '1', '2007','250', 'Dizel'),
('2', '3', '1990', '180','Dizel'),
('4', '3', '2015','120', 'Dizel'),
('3', '2', '2011','360','Dizel');


SELECT * FROM Cars
SELECT *FROM Brands
SELECT*FROM Colors


















