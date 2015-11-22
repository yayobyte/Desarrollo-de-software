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
    public class clsCliente
    {
        #region Atributes
        /*Table attributes */
        private string sNombre;
        private string sCorreo;

        /*Local Attributes*/
        private string sError;
        private DropDownList oComboCliente;
        private string sSQL;

        #endregion

        #region Properties

        public string nombre {
            set { sNombre = value; }
            get { return sNombre; }
        }

        public string correo {
            set { sCorreo = value; }
            get { return sCorreo; }
        }

        public string error {
            get { return sError; }
        }

        public DropDownList comboCliente {
            set { oComboCliente = value; }
            get { return oComboCliente; }
        }

        public string SQL {
            set { sSQL = value; }
            get { return sSQL; }
        }

        #endregion

        #region Methods
        public bool LlenarCombo()
        {
            if (oComboCliente == null)
            {
                sError = "No definió el combo del Cliente";
                return false;
            }
            sSQL = "Execute tblCliente_Combo";

            clsCombos oCombo = new clsCombos();
            oCombo.SQL = sSQL;
            oCombo.ColumnaTexto = "Nombre";//Nombre de la columna que quiero mostrar en el combo
            oCombo.ColumnaValor = "Codigo";//Nombre de la columna que quiero almacenar
            oCombo.cboGenericoWeb = oComboCliente;

            if (oCombo.LlenarComboWeb())
            {
                oComboCliente = oCombo.cboGenericoWeb;
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
