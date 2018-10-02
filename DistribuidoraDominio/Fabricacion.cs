using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DistribuidoraDominio
{
    public class Fabricacion
    {
        #region Atributos
        private string descripcion;
        private int tiempo;
        //private Empleado empleado;
        #endregion

        #region Properties
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        #endregion

        #region Constructor
        public Fabricacion()
        {

        }
        #endregion

        #region otros metodos
        public bool asignacionTecnicos(string email, int codigo)
        {
            string cadenaComando =
             @"EXEC ALTAFABRICACION @descripcion,@tiempo, '" + email + "'," + codigo;
            Conexion objetoConexion = new Conexion();
            SqlConnection cn = Conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand
                (cadenaComando, (SqlConnection)cn);
            cmd.Parameters.Add(new SqlParameter("@descripcion", this.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@tiempo", this.Tiempo));
            try
            {
                Conexion.AbrirConexion(cn);
                int filas = cmd.ExecuteNonQuery();
                if (filas == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Assert(false, "Error: " +
                    ex.Message);
                return false;
            }
            finally
            {
                Conexion.CerrarConexion(cn);
            }

        }
        #endregion

    }
}

