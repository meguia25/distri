using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.WFEmpleadoReference;


namespace Distribuidora
{
    public partial class AltaEmpleadoo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpleadoServiceClient clienteProxyDelServicio = new EmpleadoServiceClient();
            clienteProxyDelServicio.Open();
            

        }
        protected void BtnAlta_Click(object sender, EventArgs e)
        {

            bool altaEmpleado = false;

            string nombre = this.TxtNombre.Text;
            string contrasenia = this.TxtContrasenia.Text;
            string email = this.TxtContrasenia.Text;

            //Empleado emp = new Empleado
            //{
            //    Nombre = nombre,
            //    Contrasenia = contrasenia,
            //    Email = email
            //};


        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}