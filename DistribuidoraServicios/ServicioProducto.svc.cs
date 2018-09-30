using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioProducto.svc o ServicioProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioProducto : IProductoService
    {
        public bool insertarImportado(int codigo, string nombre, string descripcion, double costo, double precioSugerido, string paisOrigen, int cantMinima)
        {
            Importado i = new Importado()
            {
                Codigo = codigo,
                Nombre = nombre,
                Descripcion = descripcion,
                Costo = costo,
                PrecioSugerido = precioSugerido,
                PaisOrigen = paisOrigen,
                CantMinima = cantMinima

            };

            return i.Insertar();
        }
    }
}
