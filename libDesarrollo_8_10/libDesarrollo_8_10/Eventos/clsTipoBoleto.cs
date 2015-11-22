using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using libComunes.CapaDatos;
using libComunes.CapaObjetos;

namespace libDesarrollo_8_10.Eventos
{
    public class clsTipoBoleto
    {
        #region Attributes
        /*Table attributes*/
        private Int32 iIdTipoBoleto;
        private string sNombreTipoBoleto;

        /*Local Attributes*/
        private string sError;
        private DropDownList oComboTipoBoleto;
        private string sSQL;
        #endregion

        #region Properties
        /*Table Properties*/
        public Int32 idTipoBoleto
        {
            set { iIdTipoBoleto = value; }
            get { return iIdTipoBoleto; }
        }

        public string nombreTipoBoleto
        {
            set { sNombreTipoBoleto = value; }
            get { return sNombreTipoBoleto; }
        }

        /*Local Properties*/
        public string error
        {
            get { return sError; }
        }

        public DropDownList comboTipoBoleto
        {
            set { oComboTipoBoleto = value; }
            get { return oComboTipoBoleto; }
        }

        #endregion

        #region Methods

        public bool LlenarCombo()
        {
            if (oComboTipoBoleto == null)
            {
                sError = "No definió el combo del Tipo de Boleto";
                return false;
            }
            sSQL = "Execute tblTipoBoleto_Combo";

            clsCombos oCombo = new clsCombos();
            oCombo.SQL = sSQL;
            oCombo.ColumnaTexto = "Nombre";//Nombre de la columna que quiero mostrar en el combo
            oCombo.ColumnaValor = "Codigo";//Nombre de la columna que quiero almacenar
            oCombo.cboGenericoWeb = oComboTipoBoleto;

            if (oCombo.LlenarComboWeb())
            {
                oComboTipoBoleto = oCombo.cboGenericoWeb;
                oCombo = null;
                return true;
            }
            else
            {
                sError = oCombo.Error;
                oCombo = null;
                return false;
            }
        }
        #endregion
    }
}
