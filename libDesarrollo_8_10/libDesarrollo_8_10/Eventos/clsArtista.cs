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
    public class clsArtista
    {
        #region Attributes
        /*Table attributes*/
        private Int32 iIdArtista;
        private string sNombreArtista;

        /*Local Attributes*/
        private string sError;
        private DropDownList oComboArtista;
        private string sSQL;
        #endregion

        #region Properties
        /*Table Properties*/
        public Int32 dEveiIdArtista {
            set { iIdArtista = value; }
            get { return iIdArtista; }
        }

        public string NombreArtista{
            set { sNombreArtista = value; }
            get { return sNombreArtista; }
        }

        /*Local Properties*/
        public string error {
            get { return sError; }
        }

        public DropDownList ComboArtista {
            set { oComboArtista = value; }
            get { return oComboArtista; }
        }

        #endregion

        #region Methods
        public bool LlenarCombo()
        {
            if (oComboArtista == null)
            {
                sError = "No definió el combo del Artista";
                return false;
            }
            sSQL = "Execute tblArtista_Combo";

            clsCombos oCombo = new clsCombos();
            oCombo.SQL = sSQL;
            oCombo.ColumnaTexto = "Nombre";//Nombre de la columna que quiero mostrar en el combo
            oCombo.ColumnaValor = "Codigo";//Nombre de la columna que quiero almacenar
            oCombo.cboGenericoWeb = oComboArtista;

            if (oCombo.LlenarComboWeb())
            {
                oComboArtista = oCombo.cboGenericoWeb;
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

