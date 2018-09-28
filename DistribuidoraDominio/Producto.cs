using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DistribuidoraDominio
{
    public abstract class Producto : IActiveRecord
    {
        #region Atributos

        private int codigo;
        private string nombre;
        private string descripcion;
        private double costo;
        private double precioSugerido;

        #endregion

        #region Properties
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public double PrecioSugerido
        {
            get { return precioSugerido; }
            set { precioSugerido = value; }
        }
        #endregion

        #region Constructor
        public Producto()
        {

        }
        public Producto(int codigo, string nombre, string descripcion, double costo, double precioSugerido)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioSugerido = precioSugerido;
        }
        #endregion

        public bool Insertar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar()
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<Producto> FindAllProductos()
        {
            List<Producto> listaP = new List<Producto>();
            //Preparar el comando
            string cadenaComando =
                @"SELECT * FROM DProducto";
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
                    Producto p = CargarDesdeRegistro(dr);
                    if (p != null)
                        listaP.Add(p);
                }
                return listaP;
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
        public static Producto CargarDesdeRegistro(IDataRecord dr)
        {

            Producto p = null;
            if (dr != null)
            {
                p = new Fabricado
                {

                    Codigo = dr["Codigo"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Codigo"]),
                    Nombre = dr["Nombre"] == DBNull.Value ? "No tiene nombre" : dr["Nombre"].ToString(),
                    Descripcion = dr["Descripcion"] == DBNull.Value ? "No tiene descripción" :
                                                            dr["Descripcion"].ToString(),
                };

            }
            return p;

        }
    }
}
