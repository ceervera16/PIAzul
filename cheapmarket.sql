CREATE DATABASE IF NOT EXISTS CheapMarket CHARACTER SET UTF8;

USE CheapMarket;

CREATE TABLE carritotemporal (
  DniCliente varchar(9) NOT NULL,
  CodProducto int(5) NOT NULL,
  NomProducto varchar(150) NOT NULL,
  Cantidad int(11) NOT NULL
);

CREATE TABLE cliente (
  DNI varchar(9) NOT NULL PRIMARY KEY,
  Nombre varchar(50) NOT NULL,
  Apellidos varchar(100) NOT NULL,
  Correo varchar(100) NOT NULL,
  Password int(11) NOT NULL,
  Telefono int(9) NOT NULL,
  Puntos int(5) DEFAULT NULL,
  Provincia varchar(100) NOT NULL,
  Localidad varchar(100) NOT NULL,
  Calle varchar(250) NOT NULL,
  CodigoPostal int(5) NOT NULL,
  Patio int(3) NOT NULL,
  Piso int(2) NOT NULL,
  Puerta int(3) NOT NULL
);

CREATE TABLE producto (
  Codigo int(5) NOT NULL PRIMARY KEY,
  Nombre varchar(150) NOT NULL,
  Precio decimal(10,0) NOT NULL,
  Categoria varchar(50) NOT NULL,
  Informacion varchar(1000) DEFAULT NULL
);

CREATE TABLE compra (
  ID int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Fecha date NOT NULL,
  DniCliente varchar(9),
  CodProducto int(5),
  Cantidad int(9) NOT NULL,
  FOREIGN KEY (DniCliente) REFERENCES cliente (DNI) ON DELETE SET NULL,
  FOREIGN KEY (CodProducto) REFERENCES producto (Codigo) ON DELETE SET NULL
);