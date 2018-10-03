using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.WSAsignacionReference;


namespace Distribuidora
{
    public partial class AsignacionEmpProdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = (string)Session["empleado"];
            if (u == null)
            {
                Response.Redirect("InicioLoginn.aspx");
            }
            else
            {
                using (WSAsignacionReference.AsignacionTecnicoClient clienteProxyDelServicio = new AsignacionTecnicoClient())
                {
                    if (!IsPostBack)
                    {
                        var listado = clienteProxyDelServicio.ListaProductos(u);
                    var tecnicos = clienteProxyDelServicio.ListaTecnicos();

                    DDLProductos.DataSource = listado;
                    DDLProductos.DataTextField = "Codigo";
                    DDLProductos.DataValueField = "Codigo";
                    DDLProductos.DataBind();


                    DDLTecnicos.DataSource = tecnicos;
                    DDLTecnicos.DataTextField = "Email";
                    DDLTecnicos.DataValueField = "Email";
                    DDLTecnicos.DataBind();
                    }
                }

            }

        }
        protected void BtnAlta_Click(object sender, EventArgs e)
        {
            int codigoProducto = (int.Parse(DDLProductos.SelectedItem.Value));
            string email = (DDLTecnicos.SelectedItem.Value).ToString();
            int tiempo = int.Parse(TxtTiempo1.Text);
            string descripcion = TxtDescripcion.Text;
            using(WSAsignacionReference.AsignacionTecnicoClient clienteProxyDelServicio = new AsignacionTecnicoClient())
            {
                clienteProxyDelServicio.AsignacionTecnico(email, codigoProducto, descripcion, tiempo);
                LblMensaje.Text = "Asignacion de tecnico realizada";
            }

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}