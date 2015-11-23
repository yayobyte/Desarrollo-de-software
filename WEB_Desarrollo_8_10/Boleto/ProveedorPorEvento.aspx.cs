using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10.Eventos;

namespace WEB_Desarrollo_8_10.Boleto
{
    public partial class ProveedorPorEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //LlenarGrid();
                //LlenarComboProducto();
                LlenarComboProveedor();
            }
        }

        private void LlenarComboProveedor()
        {

            clsProveedor oProveedor = new clsProveedor();
            oProveedor.ComboProveedor = comboViewProveedor;
            if (!oProveedor.LlenarCombo())
            {
                lblError.Text = oProveedor.error;
            }
            oProveedor = null;
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

        }
    }
}