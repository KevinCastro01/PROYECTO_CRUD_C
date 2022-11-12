using PROYECTO_11_11.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_11_11.Controllers
{
    class ImprimirAreas
    {
        public static void ImprimirArea(List<Areas> Areas)
        {
            foreach (var item in Areas)
            {
                Console.WriteLine("Id: {0} Nombre: {1} ", item.Id,
                    item.Nombre);
            }
        }
    }
}
