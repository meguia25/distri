﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DistribuidoraDominio;
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

                    var listado = clienteProxyDelServicio.ListaProductos(u);
                    var tecnicos = clienteProxyDelServicio.ListaTecnicos();

                    DDLProductos.DataSource = listado;
                    DDLProductos.DataTextField = "Codigo";
                    DDLProductos.DataValueField = "Codigo";
                    DDLProductos.DataBind();


                    DDLTecnicos.DataSource = tecnicos;
                    DDLTecnicos.DataTextField = "Nombre";
                    DDLTecnicos.DataValueField = "Nombre";
                    DDLTecnicos.DataBind();
                }

            }

        }
        protected void BtnAlta_Click(object sender, EventArgs e)
        {
            int codigoProducto = (int.Parse(DDLProductos.SelectedItem.Value));
            string nombreTecnico = (DDLTecnicos.SelectedItem.Value).ToString();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void DDLProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDLProductos.SelectedValue = DDLProductos.SelectedItem.Value;
        }

        protected void DDLTecnicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDLTecnicos.SelectedValue = DDLTecnicos.SelectedItem.Value;
        }
    }
}