using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioListadoTodosProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioListadoTodosProducto.svc o ServicioListadoTodosProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioListadoTodosProducto : IListadoTodosProducto
    {
        public IEnumerable<DTOListadoTodosProducto> listado()
        {
            IEnumerable<Producto> listaCompleta = Producto.FindAllProductos();
            if (listaCompleta == null) return null;
            List<DTOListadoTodosProducto> losProductos = new List<DTOListadoTodosProducto>();
            foreach (Producto f in listaCompleta)
            {
                losProductos.Add(new DTOListadoTodosProducto()
                { Nombre = f.Nombre, Codigo = f.Codigo });
            }
            return losProductos;
        }
    }
}
