using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


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
            //Fabricado fab = new Fabricado();
            //Importado imp = new Importado();

            bool altaProducto = false;

            int codigo = int.Parse(this.TxtCodigo.Text);
            string nombre = this.TxtNombre.Text;
            string contrasenia = this.TxtDescripcion.Text;
            double costo = double.Parse(this.TxtCosto.Text);
            double precioSugerido = double.Parse(this.TxtPrecioSugerido.Text);

            bool fabricado = this.RdbFabricado.Checked;
            bool importado = this.RdbImportado.Checked;

            if (fabricado)
            {
                //altaProducto = fab.Insertar();
            }
            else if (importado)
            {
                //altaProducto = imp.Insertar();
            }  

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}