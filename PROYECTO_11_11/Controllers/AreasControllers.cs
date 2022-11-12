using PROYECTO_11_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROYECTO_11_11.Controllers
{
    class AreasControllers
    {
        public AreasControllers()
        {
            _Areas = new List<Areas>();
        }
        private List<Areas> _Areas;
        public List<Areas> Areas { get { return _Areas; } }

        #region TRAER AREAS
        //TRAER AREAS
        public void get()
        {
            //List<Areas> lista = new List<Areas>();
            //lista.AddRange(from o in Areas select o);
            ImprimirAreas.ImprimirArea(Areas);
        }
        #endregion

        #region TRAER X ID
        public void getbyId(int id)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.Id == id orderby o.Id descending select o);
            if (lista.Count > 0)
            {
                ImprimirAreas.ImprimirArea(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nuestra BD");
            }

        }
        #endregion getbyid

        #region AGREGAR AREA
        public void post(int id, string nombre)
        {
            var verificarId = Areas.Any(i => i.Id == id);
            if (!verificarId)
            {
                Areas.Add(new Areas()
                {
                    Id = id,
                    Nombre = nombre
                });
                Console.WriteLine("201");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }
        }
        #endregion

        #region ACTUALIZAR AREA
        public void update(int id, string nombre)
        {
            var ReplaceItem = new Areas
            {
                Id = id,
                Nombre = nombre
            };
            var element = Areas.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if (element != null)
            {
                Areas.Remove(element);
                Areas.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }
        }
        #endregion Update

        #region ELIMINAR AREA
        public void DeletexId(int id)
        {
            var element = Areas.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Areas.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }
        }
        #endregion delete
    }
}
