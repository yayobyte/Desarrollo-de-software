using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10.Eventos;

namespace WEB_Desarrollo_8_10.Boleto
{
    public partial class Maestros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarGridCliente();
                //LlenarComboEvento();
                //LlenarComboProveedor();
            }

        }

        private void LlenarGridCliente()
        {

            clsCliente oCliente = new clsCliente();
            
            oCliente.gridCliente = gridViewCliente;
            if (!oCliente.LlenarGrid())
            {
                lblError.Text = oCliente.error;
            }
            oCliente = null;
            
        }
    }
}