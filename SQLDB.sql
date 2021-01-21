Create table Clientes(
	Nombre [varchar](50) NULL,
	Apellido [varchar](50) NULL,
	Telefono [varchar](50) NULL,
	Documento [int] NULL,
	idCliente [int] PRIMARY KEY NOT NULL);
 CREATE TABLE Detalle(
	[idDetalle] [int] PRIMARY KEY NOT NULL,
	[idProducto] [int] NULL,
	[idCliente] [int] NULL,
	[Detalle] [varchar](50) NULL,
	[Fecha] [date] NULL);
 CREATE TABLE Productos(
	[idProducto] [int] PRIMARY KEY NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [int] NULL,
	[Cantidad] [int] NULL);
	ALTER TABLE Detalle  WITH CHECK ADD  CONSTRAINT FK_Detalle_Clientes FOREIGN KEY(idCliente)
REFERENCES Clientes (idCliente)
ALTER TABLE Detalle  WITH CHECK ADD  CONSTRAINT FK_Detalle_Productos FOREIGN KEY(idProducto)
REFERENCES Productos (idProducto)
ALTER TABLE Detalle CHECK CONSTRAINT FK_Detalle_Productos