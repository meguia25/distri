using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    [DataContract]
    public class DTOListadoPorTipo
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public double Costo { get; set; }
        [DataMember]
        public double PrecioSugerido { get; set; }
        [DataMember]
        public double Tiempo { get; set; }
        [DataMember]
        public string PaisOrigen { get; set; }
        [DataMember]
        public int CantMinima { get; set; }
    }
}