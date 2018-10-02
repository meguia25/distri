using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.WSListadoPorTipoReference;

namespace Distribuidora
{
    public partial class ListadoPorTipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (WSListadoPorTipoReference.ServicioListadoPorTipoClient clienteProxyDelServicio = new ServicioListadoPorTipoClient())
            {
                var listadoFabricados = clienteProxyDelServicio.listadoFabricados();
                var listadoImportados = clienteProxyDelServicio.listadoImportados();
                //Session["email"].ToString()
                GRVFabricado.DataSource = listadoFabricados;
                GRVFabricado.DataBind();

                GRVImportado.DataSource = listadoImportados;
                GRVImportado.DataBind();
            }
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}