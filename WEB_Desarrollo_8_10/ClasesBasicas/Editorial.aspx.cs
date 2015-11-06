using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10.Clases;
using libDesarrollo_8_10;

namespace WEB_Desarrollo_8_10.ClasesBasicas
{
    public partial class Editorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string sTipoImpresion, sTipoPasta;
            Int32 iNroImagenes, iNroHojas;

            sTipoImpresion = txtTipoImpresion.Text;
            sTipoPasta = txtTipoPasta.Text;
            iNroHojas = Convert.ToInt32(txtNroHojas.Text);
            iNroImagenes = Convert.ToInt32(txtNroImagenes.Text);

            clsImpresionLibro oImpresionLibro = new clsImpresionLibro();
            

            oImpresionLibro.NumeroImagen = iNroImagenes;
            oImpresionLibro.CantidadHojas = iNroHojas;
            oImpresionLibro.TipoImpresion = sTipoImpresion;
            oImpresionLibro.TipoPasta = sTipoPasta;

            oImpresionLibro.CalcularTotal();

            if (oImpresionLibro.Error != "")
            {
                lblError.Text = oImpresionLibro.Error;

                lblValorIVA.Text = "";
                lblValorPagar.Text = "";
            }
            else
            {
                lblValorIVA.Text = oImpresionLibro.ValorIVA.ToString();
                lblValorPagar.Text = oImpresionLibro.ValorPagar.ToString();

                lblError.Text = "";
            }

            oImpresionLibro = null;
        }
    }
}