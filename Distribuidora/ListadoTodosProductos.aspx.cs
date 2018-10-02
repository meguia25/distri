using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.WSTodosProductosReference;

namespace Distribuidora
{
    public partial class ListadoTodosProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["empleado"];
            if (u == null)
            {
                Response.Redirect("InicioLoginn.aspx");
            }
            using (WSTodosProductosReference.ListadoTodosProductoClient clienteProxyDelServicio = new ListadoTodosProductoClient())
            {
                var listado = clienteProxyDelServicio.listado();
                GridView1.DataSource = listado;
                GridView1.DataBind();
            }
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}