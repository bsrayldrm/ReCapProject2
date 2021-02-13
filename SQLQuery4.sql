﻿CREATE TABLE [dbo].[Rentals] (
    [RentalId]   INT  NOT NULL,
    [CarId]      INT  NOT NULL,
    [CustomerId] INT  NOT NULL,
    [RentDate]   DATE NOT NULL,
    [ReturnDate] DATE NULL,
    PRIMARY KEY CLUSTERED ([RentalId] ASC),
    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]),
    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId])
);