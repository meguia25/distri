using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DistribuidoraDominio
{
    public class Importado:Producto, IActiveRecord
    {
        #region Atributos

        private string paisOrigen;
        private int cantMinima;

        #endregion

        #region Properties
        public string PaisOrigen
        {
            get { return paisOrigen; }
            set { paisOrigen = value; }
        }

        public int CantMinima
        {
            get { return cantMinima; }
            set { cantMinima = value; }
        }
        #endregion

        #region Constructor
        public Importado()
        {

        }
        public Importado(int codigo, string nombre, string descripcion, double costo, double precioSugerido, string paisOrigen, int cantMinima):base(codigo, nombre, descripcion,costo,precioSugerido)
        {
            this.paisOrigen = paisOrigen;
            this.cantMinima = cantMinima;

        }
        #endregion

        #region Acceso a datos
        public static IEnumerable<Importado> FindAll()
        {
            List<Importado> ListaI = new List<Importado>();
            //Preparar el comando
            string cadenaComando =
                @"SELECT * FROM DImportado F JOIN DProducto P ON P.Codigo = F.Codigo";
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
                    Importado i = CargarDesdeRegistro(dr);
                    if (i != null)
                        ListaI.Add(i);
                }
                return ListaI;
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

        public static Importado CargarDesdeRegistro(IDataRecord dr)
        {

            Importado f = new Importado
            {
                Codigo = dr["Codigo"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Codigo"]),
                Nombre = dr["Nombre"] == DBNull.Value ? "No tiene nombre" : dr["Nombre"].ToString(),
                Descripcion = dr["Descripcion"] == DBNull.Value ? "No tiene descripción" : dr["Descripcion"].ToString(),
                Costo = dr["Costo"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Costo"]),
                PaisOrigen = dr["PaisOrigen"] == DBNull.Value ? "No tiene pais de origen" : dr["PaisOrigen"].ToString(),
                CantMinima = dr["CantMinima"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CantMinima"]),
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
            cmd.CommandText = @"EXEC ALTAIMPORTADO @Codigo,@nombre,@descripcion,@costo,@preciosug,@paisOri,@cantMin";
            //cmd.CommandText = @"INSERT INTO DProducto VALUES(@codigo,@nombre,@descripcion,@costo,@preciosug,@paisOri,@cantMin)";
            //cmd.CommandText = @"INSERT INTO DImportado VALUES(@codigo,@paisOri,@cantMin)";
            cmd.Parameters.Add(new SqlParameter("@codigo", this.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombre", this.Nombre));
            cmd.Parameters.Add(new SqlParameter("@descripcion", this.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@costo", this.Costo));
            cmd.Parameters.Add(new SqlParameter("@preciosug", this.PrecioSugerido));
            cmd.Parameters.Add(new SqlParameter("@paisOri", this.PaisOrigen));
            cmd.Parameters.Add(new SqlParameter("@cantMin", this.CantMinima));


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
