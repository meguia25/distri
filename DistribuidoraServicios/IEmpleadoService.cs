using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    [ServiceContract]
    public interface IEmpleadoService
    {
        [OperationContract]
        bool InsertarEmpleado(string nombre, string contrasenia, string email);
    }
}
