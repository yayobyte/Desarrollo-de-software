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
    public class clsBoleto
    {
        #region Constructor
        public clsBoleto() {
            iIdCliente = -1;
            iIdEvento = -1;
            iIdTipoBoleto = -1;
        }
        #endregion

        #region  Attributes
        /*Table attributes*/
        private int iId;
        private int iIdCliente;
        private int iIdEvento;
        private int iIdTipoBoleto;

        /*Local attributes*/
        private string sError;
        private GridView oGridBoleto;
        private string sSQL;
        #endregion

        #region Properties
        /*Table Properties*/
        public int id {
            set { iId = value; }
            get { return iId; }
        }
        public int idCliente {
            set { iIdCliente = value; }
            get { return iIdCliente; }
        }

        public int idEvento {
            set { iIdEvento = value; }
            get { return iIdEvento;  }
        }

        public int idTipoBoleto {
            set { iIdTipoBoleto = value; }
            get { return iIdTipoBoleto; }
        }

        /*Local Properties*/

        public string error {
            get { return sError; }
        }

        public GridView gridBoleto {
            set { gridBoleto = value; }
            get { return gridBoleto; }
        }

        #endregion

        #region Methods
        /*CRUD METODS*/
        private bool validar() { 
            if (iIdCliente<0){
                sError = "No se especifico cliente";
                return false;
            }
            if(iIdEvento<0){
                sError = "No se especifico evento";
                return false;
            }
            if (iIdTipoBoleto<0){
                sError = "No se especifico el tipo de boleto";            
            }
            return true;
        }

        public bool Grabar()
        {
            if (validar())
            {
                clsConexion oConexion = new clsConexion();
                //Lo unico que se pasa en el SQL es el nombre del procedimiento
                sSQL = "tblBoleto_Grabar";

                oConexion.SQL = sSQL;

                //Se pasan los parámetros
                //El tamaño de los parámetros "sólo aplica" para los tipo varchar
                oConexion.AgregarParametro("@pr_IDCliente", System.Data.SqlDbType.Int, 4, iIdCliente);
                oConexion.AgregarParametro("@pr_IDEvento", System.Data.SqlDbType.Int, 4, iIdEvento);
                oConexion.AgregarParametro("@pr_IDTipoBoleto", System.Data.SqlDbType.Int, 4, iIdTipoBoleto);

                if (oConexion.EjecutarSentencia())
                {
                    oConexion = null;
                    return true;
                }
                else
                {
                    sError = oConexion.Error;
                    oConexion = null;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        #endregion
    }
}
