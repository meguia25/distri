using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DistribuidoraDominio;

namespace DistribuidoraServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Empleado" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Empleado.svc o Empleado.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioEmpleado : IEmpleadoService
    {
        public bool InsertarEmpleado()
        {
            //bool alta = Empleado.Insertar();
            //if (alta)
            //{
            //    return true;
            //}
            //else
            //{
                return false;
            //}

        }
    }
}
