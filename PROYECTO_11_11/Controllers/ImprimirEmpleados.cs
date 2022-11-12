using PROYECTO_11_11.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_11_11.Controllers
{
    public class ImprimirEmpleados
    {
        public static void ImprimirEmpleado(List<Empleados> Empleados)
        {
            foreach (var item in Empleados)
            {
                Console.WriteLine("Id; {0} Nombre: {1} Apellido: {2} " +
                 " Direccion: {3} Telefono: {4} Fecha ingreso: {5} Id area: {6}", item.IdEmpleado,
                    item.NombreEmpleado, item.Apellido, item.Direccion,
                    item.Telefono, item.Fecha_ingreso, item.IdArea);
            }
        }
    }
}
