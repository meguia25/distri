using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.WSReferenceEmpleado;


namespace Distribuidora
{
    public partial class AltaEmpleadoo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void BtnAlta_Click(object sender, EventArgs e)
        {

            bool altaEmpleado = false;

            string nombre = this.TxtNombre.Text;
            string contrasenia = this.TxtContrasenia.Text;
            string email = this.TxtEmail.Text;
            using(WSReferenceEmpleado.EmpleadoServiceClient clienteProxyDelServicio = new EmpleadoServiceClient())
            {
                altaEmpleado = clienteProxyDelServicio.InsertarEmpleado(nombre, contrasenia, email);
                LblMensaje.Text = "Alta de empleado correcta";
            } 
            if(!altaEmpleado)
            {
                LblMensaje.Text = "Alta de empleado incorrecta, verifique datos";
            }
                       
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}