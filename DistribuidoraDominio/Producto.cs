using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Producto(int codigo,string nombre, string descripcion, double costo, double precioSugerido)
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
    }
}
