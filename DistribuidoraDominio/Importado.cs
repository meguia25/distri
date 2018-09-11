using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDominio
{
    public class Importado:Producto
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
    }
}
