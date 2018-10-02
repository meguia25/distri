using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioListadoPorTipo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioListadoPorTipo
    {
        [OperationContract]
        IEnumerable<DTOListadoPorTipo> listadoFabricados();

        [OperationContract]
        IEnumerable<DTOListadoPorTipo> listadoImportados();
    }
}
