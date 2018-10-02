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
    interface IProductoService
    {
        [OperationContract]
        bool insertarImportado(int codigo, string nombre, string descripcion, double costo, double precioSugerido, string paisOrigen, int cantMinima);

        [OperationContract]
        bool insertarFabricado(int codigo, string nombre, string descripcion, double costo, double precioSugerido, double tiempo);

        [OperationContract]
        bool actualizarEmpleado(string email, int codigo);
    }
}
