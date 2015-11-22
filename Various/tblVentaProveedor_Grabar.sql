USE [DBEventos]
GO
 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[tblVentaProveedor_Grabar]


@pr_IDVenta			int,
@pr_IDProveedor			int,
@pr_IDProducto			int


AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO tblVentaProveedor (IDVenta, IDProveedor, IDProducto)
	VALUES (@pr_IDVenta, @pr_IDProveedor, @pr_IDProducto)
END
GO

