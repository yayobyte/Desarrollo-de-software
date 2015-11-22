USE [DBEventos]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblEvento_Grid]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT		EVE.ID , EVE.NombreEvento , EVE.fecha,
				EST.Nombre , EST.Capacidad, TEVE.NombreTipoEvento,
				ART.Nombre
				

	FROM		tblEvento AS EVE
		INNER JOIN tblEstablecimiento AS EST
			ON EVE.IDEstablecimiento = EST.ID
		INNER JOIN tblArtista AS ART
			ON EVE.IDArtista = ART.ID
		INNER JOIN	tblTipoEvento AS TEVE
			ON EVE.IDTipoEvento = TEVE.ID
		
END