using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Paso 1. Agregar la referencia 
//-- Rerences boton derecho se busca el archivo .dll por examinar

//Paso 2. Llamar la instrucción using para utilizar la librería
using libDesarrollo_8_10.Clases;

namespace WEB_Desarrollo_8_10.ClasesBasicas
{
    public partial class Taller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            //Paso 3. Capturar la información de la interfaz
            //se definen las variables y se captura
            Int32 iCostoManoObra, iCostoRepuestos;
            double dPorcentajeDescuento;
            iCostoManoObra = Convert.ToInt32(txtCostoManoObra.Text);
            iCostoRepuestos = Convert.ToInt32(txtCostoRepuestos.Text);
            dPorcentajeDescuento = Convert.ToDouble(txtPorcentajeDescuento.Text);
            
            //Paso 4. Crear la instancia del objeto
            //NombreClase NombreObjeto = new NombreClase();
            clsReparacionMoto oReparacionMoto = new clsReparacionMoto();

            //Paso 5. Definir las propiedades de entrada
            oReparacionMoto.ValorRepuestos = iCostoRepuestos;
            oReparacionMoto.ValorManoObra = iCostoManoObra;
            oReparacionMoto.PorcentajeDescuento = dPorcentajeDescuento;

            //Paso 6. Ejecutar el metodo o metodos
            if (oReparacionMoto.CalcularTotal())
            {
                //Paso 7. Capturo respuestas o el error
                lblTotalPagar.Text = oReparacionMoto.ValorTotalPagar.ToString();
                lblValorAntesIVA.Text = oReparacionMoto.ValorAntesIva.ToString();
                lblValorDescuento.Text = oReparacionMoto.ValorDescuento.ToString();
                lblValorIVA.Text = oReparacionMoto.ValorIva.ToString();
            }
            else
            {
                //Paso 7. Capturo respuestas o el error
                lblError.Text = oReparacionMoto.Error;
            }

            //Ultimo paso. Liberar memoria
            oReparacionMoto = null;
        }
    }
}