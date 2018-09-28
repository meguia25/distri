using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    [DataContract]
    public class DTOEmpleado
    {
        [DataMember]
        private string Nombre { get; set; }

        [DataMember]
        private string Contrasenia { get; set; }

        [DataMember]
        private string Email { get; set; }
    }
}