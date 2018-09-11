using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace DistribuidoraDominio
{
    public class Conexion
    {
        //creamos la conexion
        public static SqlConnection CrearConexion()
        {
            //compu Mariana
            return new SqlConnection(@"SERVER=LAPTOP-GUDD2GCN;DATABASE=BDDistribuidora;INTEGRATED SECURITY=TRUE;");
            //en la facultad
            //return new SqlConnection(@"SERVER=(local);DATABASE=BDDistribuidora;INTEGRATED SECURITY=TRUE;");
            //compu Jennifer - no anda
            //return new SqlConnection(@"SERVER=DESKTOP-KOK8NDO\SQLEXPRESS;DATABASE=BDDistribuidora;INTEGRATED SECURITY=TRUE;");
        }

        public static bool CerrarConexion(SqlConnection unaConexion)
        {
            unaConexion.Close();
            unaConexion.Dispose();
            return true;
        }

        public static bool AbrirConexion(SqlConnection unaConexion)
        {
            unaConexion.Open();
            return false;
        }
    }
}
