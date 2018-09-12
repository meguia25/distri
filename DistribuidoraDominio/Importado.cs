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

        #region ActiveRecord
        public bool Insertar()
        {
            SqlConnection cn = Conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"INSERT INTO DProducto VALUES(@codigo,@nombre,@descripcion,@costo,@preciosug,@paisOri,@cantMin)";
            cmd.Parameters.Add(new SqlParameter("@codigo", this.Codigo));
            cmd.Parameters.Add(new SqlParameter("@nombre", this.Nombre));
            cmd.Parameters.Add(new SqlParameter("@descripcion", this.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@costo", this.Costo));
            cmd.Parameters.Add(new SqlParameter("@preciosug", this.PrecioSugerido));
            cmd.Parameters.Add(new SqlParameter("@paisOri", this.PrecioSugerido));
            cmd.Parameters.Add(new SqlParameter("@cantMin", this.PrecioSugerido));

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
