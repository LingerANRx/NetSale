CREATE DATABASE NetSaleData
use NetSaleData

CREATE TABLE Administrador(
Nombre nvarchar(50),
Pass nvarchar(14))

CREATE TABLE Usuarios(
Nombre nvarchar(50),
Pass nvarchar(14))

CREATE TABLE Productos(
Producto nvarchar(30),
Cantidad int,
Precio decimal(5,2))

SELECT Nombre, Pass FROM Usuarios
SELECT Nombre, Pass FROM Administrador
SELECT * FROM Productos


