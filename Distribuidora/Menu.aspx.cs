using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Distribuidora
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaEmpleadoo.aspx");
        }

        protected void BtnProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaProductoo.aspx");
        }
        protected void BtnAsignacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsignacionEmpProdd.aspx");
        }

        protected void BtnListado_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoProdFabb.aspx");
        }

        protected void BtnListadoProd_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoTodosProductos.aspx");
        }
    }
}