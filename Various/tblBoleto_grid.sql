USE [DBEventos]
GO
/****** Object:  StoredProcedure [dbo].[Servicio_Grid]    Script Date: 21/11/2015 4:15:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[tblBoleto_Grid]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT		B.ID, B.IDCliente,B.IDEvento,B.IDTipoBoleto

	FROM		tblBoleto AS B
		INNER JOIN tblTipoBoleto AS TB 
			ON B.IDTipoBoleto = TB.IDTipoBoleto 
		INNER JOIN tblCliente AS C
			ON B.IDCLiente = C.ID
		INNER JOIN tblEvento AS E
			ON B.IDEvento = E.ID 
	
END