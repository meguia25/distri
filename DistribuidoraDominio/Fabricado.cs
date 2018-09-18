using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DistribuidoraDominio
{
    public class Fabricado:Producto,IActiveRecord 
    {
        #region Atributos

        private double tiempo;
        private ICollection<Fabricacion> listaFab;

        #endregion

        #region Properties
        public double Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        public ICollection<Fabricacion> ListaFab
        {
            get { return listaFab; }
            set { listaFab = value; }
        }
        #endregion

        #region Constructor
        public Fabricado()
        {

        }
        public Fabricado(int codigo, string nombre, string descripcion, double costo, double precioSugerido, double tiempo, ICollection<Fabricacion> listaFab) : base(codigo, nombre, descripcion, costo, precioSugerido)
        {
            this.tiempo = tiempo;
            this.listaFab = listaFab;

        }
        #endregion

        #region Acceso a datos
        public static IEnumerable<Fabricado> FindAll()
        {
            List<Fabricado> ListaF = new List<Fabricado>();
            //Preparar el comando
            string cadenaComando =
                @"SELECT * FROM DFabricado F JOIN DProducto P ON P.Codigo = F.Codigo";
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
                    Fabricado f = CargarDesdeRegistro(dr);
                    if (f != null)
                        ListaF.Add(f);
                }
                return ListaF;
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

        public static Fabricado CargarDesdeRegistro(IDataRecord dr)
        {

            Fabricado f = new Fabricado
            {
                Tiempo = dr["Tiempo"] ==                    DBNull.Value ?
                                                            0
                                                           : Convert.ToDouble(dr["Tiempo"]),
                
                Codigo = dr["Codigo"] == DBNull.Value ?
                                                            0 :
                                                            Convert.ToInt32(dr["Codigo"]),
                Nombre = dr["Nombre"] == DBNull.Value ?
                                                            "No tiene nombre" :
                                                            dr["Nombre"].ToString(),
                Descripcion = dr["Descripcion"] == DBNull.Value ?
                                                            "No tiene descripción" :
                                                            dr["Descripcion"].ToString(),
                Costo = dr["Costo"] == DBNull.Value ?
                                                            0
                                                           : Convert.ToDouble(dr["Costo"]),
            };
            return f;

        }
        #endregion

        #region ActiveRecord
        public bool Insertar()
        {
            SqlConnection cn = Conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"INSERT INTO DProducto VALUES(@codigo,@nombre,@descripcion,@costo,@preciosug,@empleado)";
            cmd.Parameters.Add(new SqlParameter("@codigo", this.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombre", this.Nombre));
            cmd.Parameters.Add(new SqlParameter("@descripcion", this.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@costo", this.Costo));
            cmd.Parameters.Add(new SqlParameter("@preciosug", this.PrecioSugerido));
           // cmd.Parameters.Add(new SqlParameter("@empleado", this.Environment.UserName)); //Esta bien?
            cmd.CommandText = @"INSERT INTO DFabricado VALUES(@tiem,@lista)";
            cmd.Parameters.Add(new SqlParameter("@tiem", this.PrecioSugerido));
            cmd.Parameters.Add(new SqlParameter("@lista", this.PrecioSugerido));

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
    }
}
