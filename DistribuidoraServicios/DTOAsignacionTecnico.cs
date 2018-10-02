using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    [DataContract]
    public class DTOAsignacionTecnico
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Tiempo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

    }
}
