using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.ServiceReferenceListadoProdFab;

namespace Distribuidora
{
    public partial class ListadoProdFabb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ServiceReferenceListadoProdFab.ListadoProdFabServiceClient clienteProxyDelServicio = new ListadoProdFabServiceClient())
            {
                var listado = clienteProxyDelServicio.listado();
                //Session["email"].ToString()
                GridView1.DataSource = listado;
                GridView1.DataBind();
            }

            //ServiceReferenceListadoProdFab.ListadoProdFabServiceClient clienteProxyDelServicio = new ListadoProdFabServiceClient();//este es el cliente que sabe còmo usar el servicio, no devuelve una lista
            //clienteProxyDelServicio.Open();
            //var listado = clienteProxyDelServicio.listado();
            //clienteProxyDelServicio//aca tenemos que acceder al mètodo que devuelve un IEnumerable de DTO
            //Listar();
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}