using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10;
using libDesarrollo_8_10.Clases;
using LibreriaTor;

namespace WEB_Desarrollo_8_10.ClasesBasicas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sCategoria;
            Int32 iNroEntreNadores, iNroParTidos;


            sCategoria = txtCateGoria.Text;
            iNroEntreNadores = Convert.ToInt32(txtNroEntrena.Text);
            iNroParTidos = Convert.ToInt32(txtNroParTidos.Text);
           

            clsInscripcion oTorneo = new clsInscripcion();


            oTorneo.NroEntrenadores = iNroEntreNadores;
            oTorneo.NroPartidos = iNroParTidos;
            oTorneo.Categoria = sCategoria;





            oTorneo.CalcularInscripcion();



            if (oTorneo.Error != "")
            {
                lblError.Text = oTorneo.Error;

                lblTotal.Text = "";

            }
            else
            {
                lblTotal.Text = oTorneo.TotalInscripcion.ToString();


                lblError.Text = "";
            }

            oTorneo = null;
        }
    }
}