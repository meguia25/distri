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
    public interface IAsignacionTecnico
    {
        [OperationContract]
        IEnumerable<DTOAsignacionTecnico> ListaTecnicos();

        [OperationContract]
        IEnumerable<DTOAsignacionTecnico> ListaProductos(string email);

        [OperationContract]
        bool AsignacionTecnico(string email, int codigo, string descripcion, int tiempo);


    }
}
