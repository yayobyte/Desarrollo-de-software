using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10.Clases;

namespace WEB_Desarrollo_8_10.ReglasNeglocio
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecargar_Click(object sender, EventArgs e)
        {
            Int32 iValorRecarga;
            string sNumeroCelular;

            iValorRecarga = Convert.ToInt32(txtValorRecarga.Text);
            sNumeroCelular = txtCelular.Text;

            clsRecargaMinutos oRecargar = new clsRecargaMinutos();

            oRecargar.ValorRecarga = iValorRecarga;
            oRecargar.NumeroCelular = sNumeroCelular;

            if (oRecargar.Recargar())
            {
                lblMinutosRecargados.Text = oRecargar.MinutosRecargados.ToString();
                lblMinutosAdicionales.Text = oRecargar.MinutosAdicionales.ToString();
                lblMinutosTotales.Text = oRecargar.TotalMinutos.ToString();

                lblError.Text = "";
            }
            else
            {
                lblError.Text = oRecargar.Error;

                lblMinutosRecargados.Text = "";
                lblMinutosAdicionales.Text = "";
                lblMinutosTotales.Text = "";
            }
            oRecargar = null;
        }
    }
}