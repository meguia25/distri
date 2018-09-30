using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.WSProductoReference;


namespace Distribuidora
{
    public partial class AltaProductoo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TxtTiempo.Visible = false;
            //TxtCantMinima.Visible = false;
            //TxtPaisOrigen.Visible = false;
            String u = (string)Session["empleado"];

        }
        protected void BtnAlta_Click(object sender, EventArgs e)
        {

            String u = (string)Session["empleado"];

            bool altaProducto = false;

            int codigo = int.Parse(this.TxtCodigo.Text);
            string nombre = this.TxtNombre.Text;
            string descripcion = this.TxtDescripcion.Text;
            double costo = double.Parse(this.TxtCosto.Text);
            double precioSugerido = double.Parse(this.TxtPrecioSugerido.Text);
            string paisOrigen = this.TxtPaisOrigen.Text;
            int cantMinima = int.Parse(this.TxtCantMinima.Text);

            bool fabricado = this.RdbFabricado.Checked;
            bool importado = this.RdbImportado.Checked;

            using(WSProductoReference.ProductoServiceClient clienteProxyDelServicio = new ProductoServiceClient())
            {
                if (fabricado)
                {
                   
                }
                else if (importado)
                {
                    altaProducto = clienteProxyDelServicio.insertarImportado(codigo, nombre, descripcion, costo, precioSugerido, paisOrigen, cantMinima);
                    LblMensaje.Text = "Alta de producto importado correcta";
                };


            }


        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}