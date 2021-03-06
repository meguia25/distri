﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Distribuidora.WSReferenceEmpleado;


namespace Distribuidora
{
    public partial class InicioLoginn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            using (WSReferenceEmpleado.EmpleadoServiceClient clienteProxyDelServicio = new EmpleadoServiceClient())
            {
                bool j =  clienteProxyDelServicio.validarU(Login1.UserName, Login1.Password);
               
                if (j == false)
                {
                    Session["empleado"] = null;
                    e.Authenticated = false;
                    Response.Redirect("InicioLogin.aspx");
                }
                else
                {
                    e.Authenticated = true;
                    Session["empleado"] = Login1.UserName;
                    Response.Redirect("Menu.aspx");
                }
            }
        }

        protected void BtnListadoTipo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoPorTipo.aspx");
        }
    }
}