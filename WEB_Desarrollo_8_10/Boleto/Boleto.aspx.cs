using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10.Eventos;

namespace WEB_Desarrollo_8_10.Boleto
{
    public partial class Boleto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                LlenarComboCliente();
                LlenarComboEvento();
                LlenarComboTipoBoleto();
                LlenarGrid();
                
            }
        }
        private void LlenarGrid()
        {
            
            clsBoleto oBoleto = new clsBoleto();
            
            oBoleto.gridBoleto = grdBoleto;
            if (!oBoleto.LlenarGrid())
            {
                lblError.Text = oBoleto.error;
            }
            oBoleto = null;
        }

        private void LlenarComboCliente()
        {
            
            clsCliente oCliente = new clsCliente();
            oCliente.comboCliente = comboViewCliente;
            if (!oCliente.LlenarCombo())
            {
                lblError.Text = oCliente.error;
            }
            oCliente = null;
        }
        private void LlenarComboEvento()
        {

            clsEvento oEvento = new clsEvento();
            oEvento.comboEvento = comboViewEvento;
            if (!oEvento.LlenarCombo())
            {
                lblError.Text = oEvento.error;
            }
            oEvento = null;
        }
        private void LlenarComboTipoBoleto()
        {

            clsTipoBoleto oTipoBoleto = new clsTipoBoleto();

            oTipoBoleto.comboTipoBoleto = comboViewTipoEvento;
            if (!oTipoBoleto.LlenarCombo())
            {
                lblError.Text = oTipoBoleto.error;
            }
            oTipoBoleto = null;
        }



        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            
            Int32 iIdCliente,iIdEvento,iIdTipoBoleto;

            iIdCliente = Convert.ToInt32(comboViewCliente.SelectedValue);
            iIdEvento = Convert.ToInt32(comboViewEvento.SelectedValue);
            iIdTipoBoleto = Convert.ToInt32(comboViewTipoEvento.SelectedValue);

            clsBoleto oBoleto = new clsBoleto();

            oBoleto.idCliente = iIdCliente;
            oBoleto.idEvento = iIdEvento;
            oBoleto.idTipoBoleto = iIdTipoBoleto;

            if (oBoleto.Grabar())
            {
                //Llenar grid
                LlenarGrid();
            }
            else
            {
                lblError.Text = oBoleto.error;
            }
            oBoleto = null;
            
        }
        
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            /*
            string sNombre;
            Int32 iValor, iCodigoTipoServicio, iCodigo;
            bool bActivo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);
            sNombre = txtNombre.Text;
            iValor = Convert.ToInt32(txtValor.Text);
            bActivo = chkActivo.Checked;
            iCodigoTipoServicio = Convert.ToInt32(cboTipoServicio.SelectedValue);

            clsServicio oServicio = new clsServicio();

            oServicio.Codigo = iCodigo;
            oServicio.Nombre = sNombre;
            oServicio.Valor = iValor;
            oServicio.Activo = bActivo;
            oServicio.CodigoTipoServicio = iCodigoTipoServicio;

            if (oServicio.Actualizar())
            {
                //Llenar grid
                LlenarGrid();
            }
            else
            {
                lblError.Text = oServicio.Error;
            }
            oServicio = null;
             * */
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            /*
            Int32 iCodigo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);
            clsServicio oServicio = new clsServicio();

            oServicio.Codigo = iCodigo;

            if (oServicio.Borrar())
            {
                //Llenar grid
                LlenarGrid();
            }
            else
            {
                lblError.Text = oServicio.Error;
            }
            oServicio = null;
             * */
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            clsBoleto oBoleto = new clsBoleto();

            oBoleto.idCliente = Convert.ToInt32(comboViewCliente.SelectedValue);
            oBoleto.gridBoleto = grdBoleto;
            if (!oBoleto.Consultar())
            {
                lblError.Text = oBoleto.error;
            }
            oBoleto = null;
        }
         
    }
}