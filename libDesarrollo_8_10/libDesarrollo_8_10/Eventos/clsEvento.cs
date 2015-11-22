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
    public class clsEvento
    {
        #region Attributes
        /*Table attributes*/
        private Int32 iIdEvento;
        private string sNombreEvento;

        /*Local Attributes*/
        private string sError;
        private DropDownList oComboEvento;
        private string sSQL;
        #endregion

        #region Properties
        /*Table Properties*/
        public Int32 idEvento {
            set { iIdEvento = value; }
            get { return iIdEvento; }
        }

        public string nombreEvento {
            set { sNombreEvento = value; }
            get { return sNombreEvento; }
        }

        /*Local Properties*/
        public string error {
            get { return sError; }
        }

        public DropDownList comboEvento {
            set { oComboEvento = value; }
            get { return oComboEvento; }
        }

        #endregion

        #region Methods
        public bool LlenarCombo()
        {
            if (oComboEvento == null)
            {
                sError = "No definió el combo del Evento";
                return false;
            }
            sSQL = "Execute tblEvento_Combo";

            clsCombos oCombo = new clsCombos();
            oCombo.SQL = sSQL;
            oCombo.ColumnaTexto = "Nombre";//Nombre de la columna que quiero mostrar en el combo
            oCombo.ColumnaValor = "Codigo";//Nombre de la columna que quiero almacenar
            oCombo.cboGenericoWeb = oComboEvento;

            if (oCombo.LlenarComboWeb())
            {
                oComboEvento = oCombo.cboGenericoWeb;
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

