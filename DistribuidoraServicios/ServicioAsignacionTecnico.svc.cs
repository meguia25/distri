using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAsignacionTecnico" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioAsignacionTecnico.svc o ServicioAsignacionTecnico.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioAsignacionTecnico : IAsignacionTecnico
    {
        public IEnumerable<DTOAsignacionTecnico> ListaProductos(string email)
        {
            IEnumerable<Fabricado> listaCompleta = Fabricado.FindFabricadoByEmail(email);
            if (listaCompleta == null) return null;
            List<DTOAsignacionTecnico> losFabricados = new List<DTOAsignacionTecnico>();
            foreach (Fabricado f in listaCompleta)
            {
                losFabricados.Add(new DTOAsignacionTecnico()
                { Nombre = f.Nombre, Codigo = f.Codigo });
            }
            return losFabricados;
        }

        public IEnumerable<DTOAsignacionTecnico> ListaTecnicos()
        {
            IEnumerable<Empleado> listaCompleta = Empleado.FindAll();
            if (listaCompleta == null) return null;
            List<DTOAsignacionTecnico> losEmpleados = new List<DTOAsignacionTecnico>();
            foreach (Empleado f in listaCompleta)
            {
                losEmpleados.Add(new DTOAsignacionTecnico()
                { Nombre = f.Nombre });
            }
            return losEmpleados;
        }
    }
}
