using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioListadoPorTipo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioListadoPorTipo.svc o ServicioListadoPorTipo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioListadoPorTipo : IServicioListadoPorTipo
    {
        public IEnumerable<DTOListadoPorTipo> listadoFabricados()
        {
            IEnumerable<Fabricado> listaCompleta = Fabricado.FindAll();
            if (listaCompleta == null) return null;
            List<DTOListadoPorTipo> losFabricados = new List<DTOListadoPorTipo>();
            foreach (Fabricado f in listaCompleta)
            {
                losFabricados.Add(new DTOListadoPorTipo()
                { Codigo = f.Codigo, Nombre = f.Nombre, Descripcion = f.Descripcion, Costo = f.Costo, PrecioSugerido = f.PrecioSugerido, Tiempo = f.Tiempo});
            }
            return losFabricados;
        }

        public IEnumerable<DTOListadoPorTipo> listadoImportados()
        {
            IEnumerable<Importado> listaCompleta = Importado.FindAll();
            if (listaCompleta == null) return null;
            List<DTOListadoPorTipo> losImportados = new List<DTOListadoPorTipo>();
            foreach (Importado i in listaCompleta)
            {
                losImportados.Add(new DTOListadoPorTipo()
                { Codigo = i.Codigo, Nombre = i.Nombre, Descripcion = i.Descripcion, Costo = i.Costo, PrecioSugerido = i.PrecioSugerido, PaisOrigen = i.PaisOrigen, CantMinima = i.CantMinima});
            }
            return losImportados;
        }
    }
}
