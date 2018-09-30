using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DistribuidoraDominio
{
    public class Empleado: IActiveRecord
    {
        #region Atributos

        private string nombre;
        private string contrasenia;
        private string email;
        #endregion

        #region Properties
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region Constructor
                public Empleado(string nombre, string contrasenia, string email)
        {
            this.nombre = nombre;
            this.email = email;
            this.contrasenia = contrasenia;
        }
        public Empleado()
        {

        }

        #endregion


        #region ActiveRecord
        public bool Insertar()
        {
            SqlConnection cn = Conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"INSERT INTO DEmpleado VALUES(@nom,@email,@contra)";
            cmd.Parameters.Add(new SqlParameter("@nom", this.Nombre));
            cmd.Parameters.Add(new SqlParameter("@email", this.Email));
            cmd.Parameters.Add(new SqlParameter("@contra", this.Contrasenia));
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

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Otros metodos

        public static bool ValidarUsuario(string email, string contrasenia)
        {
            bool encontre = false;
            string cadenaComando =
                @"SELECT * FROM DEmpleado 
                    WHERE Email=@email AND Contrasenia=@contrasenia";
            Conexion objetoConexion = new Conexion();
            SqlConnection cn = Conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand
                (cadenaComando, (SqlConnection)cn);
            cmd.Parameters.Add(new SqlParameter("@email", email.ToString()));
            cmd.Parameters.Add(new SqlParameter("@contrasenia", contrasenia.ToString()));
            try
            {
                Conexion.AbrirConexion(cn);
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    encontre = true;
                }
                return encontre;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Assert(false, "Error: " +
                    ex.Message);
                return encontre;
            }
            finally
            {
                Conexion.CerrarConexion(cn);
            }
        }

        public static IEnumerable<Empleado> FindAll()
        {
            List<Empleado> ListaE = new List<Empleado>();
            //Preparar el comando
            string cadenaComando =
                @"SELECT * FROM DEmpleado";
            Conexion objetoConexion = new Conexion();
            SqlConnection cn = Conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand
                (cadenaComando, (SqlConnection)cn);

            try
            {
                Conexion.AbrirConexion(cn);
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Empleado e = CargarDesdeRegistro(dr);
                    if (e != null)
                        ListaE.Add(e);
                }
                return ListaE;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Assert(false, "Error: " +
                    ex.Message);
                return null;
            }
            finally
            {
                Conexion.CerrarConexion(cn);
            }
        }

        public static Empleado CargarDesdeRegistro(IDataRecord dr)
        {

            Empleado e = new Empleado
            {
                Nombre = dr["Nombre"] == DBNull.Value ?
                                                            "No tiene nombre" :
                                                            dr["Nombre"].ToString(),
            };
            return e;

        }
        #endregion



    }
}
