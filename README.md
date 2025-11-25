# Creating an MVC Web App using Entity Framework Database First
## By Walter Hugo Arboleda Mazo


## SQL Server 2021 Database Creation for SampleDb Database and tables Categories and Products

CREATE DATABASE SampleDb;
GO

USE SampleDb;
GO

CREATE TABLE Categories(
CategoryId INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Products(
ProductId INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100) NOT NULL,
Price DECIMAL(18,2) NOT NULL,
CategoryId INT FOREIGN KEY REFERENCES Categories(CategoryId)
);
GO


## Installing packages using PM or Nuget

 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 Install-Package Microsoft.EntityFrameworkCore.Design
 Install-Package Microsoft.EntityFrameworkCore.Tools

## Scaffolding the DbContext and the Models from the SampleDB on MS SQL Server 2021

Scaffold-DbContext 'Server=DESKTOP-GJDFMRJ\SQLEXPRESS01;Database=SampleDb;Trusted_Connection=True;TrustServerCertificate=True;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Data -DataAnnotations -Force


## Application Views after generate Controllers and Views using Entity Framework 

<img width="1666" height="875" alt="image" src="https://github.com/user-attachments/assets/b9342235-5687-455e-95bf-d8072fa9c5ea" />


