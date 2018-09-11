using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDominio
{
    public class Fabricacion
    {
        #region Atributos
        private string descripcion;
        private TimeSpan tiempo;
        //private Empleado empleado;
        #endregion

        #region Properties
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public TimeSpan Tiempo
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


    }
}

