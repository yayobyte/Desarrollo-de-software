USE [DBEventos]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblVentaProveedor_Grid]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT		V.IDVenta, P.NombreProducto , PROV.Nombre

	FROM		tblVentaProveedor AS V
		INNER JOIN tblProducto AS P
			ON V.IDProducto = P.ID
		INNER JOIN tblProveedor as PROV
			ON V.IDProducto = PROV.ID
END

