using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10;
using libDesarrollo_8_10.Clases;

namespace WEB_Desarrollo_8_10.ReglasNeglocio
{
    public partial class TiendaDeportiva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string sMarca;
            Int32 iCantidad, IvalorUnitario;
            sMarca = txtMarca.Text;
            iCantidad =Convert.ToInt32(txtCantidad.Text);
            IvalorUnitario = Convert.ToInt32(txtValorUnitario.Text);

            clsTiendaDeportiva oTienda=new clsTiendaDeportiva();
            oTienda.Cantidad=iCantidad;
            oTienda.ValorUnitario=IvalorUnitario;
            oTienda.Marca=sMarca;


            if(oTienda.CalcularValorPagar()){
                lblError.Text="";
                lblValorAntesDescuento.Text=oTienda.valorCompra.ToString("#,000");
                 lblValorAntesIva.Text=oTienda.ValorAntesIva.ToString("#,000");
                lblValorDescuento.Text=oTienda.ValorDescuento.ToString("#,000");
                lblValorPagar.Text=oTienda.ValorPagar.ToString("#,000");
                lblValorIva.Text=oTienda.ValorIva.ToString("#,000");
            
            
            
            }
            else{
             lblError.Text=oTienda.Error;
                lblValorAntesDescuento.Text="";
                     lblValorAntesIva.Text="";
                    lblValorDescuento.Text="";
                    lblValorPagar.Text="";
                    lblValorIva.Text="";
            
            
            }
            oTienda=null;

        }
    }
}