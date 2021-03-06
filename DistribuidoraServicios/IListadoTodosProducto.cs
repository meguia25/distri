﻿using System;
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
    public interface IListadoTodosProducto
    {
        [OperationContract]
        IEnumerable<DTOListadoTodosProducto> listado();
    }
}
