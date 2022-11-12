using PROYECTO_11_11.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_11_11.Controllers
{
    class ImprimirNominas
    {
        public static void ImprimirNomina(List<Nomina> Nomina)
        {
            foreach (var item in Nomina)
            {
                Console.WriteLine("Id: {0} Fecha: {1} Id empleado: {2} " +
                 " Sueldo:{3} Dias: {4} Total basico: {5} otros: {6} devengado: {7} ", item.Id,
                    item.Fecha, item.IdEmpleados, item.Sueldo,
                    item.Dias, item.TotalBasico, item.Otros, item.Devengado);
            }
        }
    }
}
