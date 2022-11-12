using PROYECTO_11_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROYECTO_11_11.Controllers
{
    class EmpleadosControllers
    {
        public EmpleadosControllers()
        {
            _Empleados = new List<Empleados>();
        }
        private List<Empleados> _Empleados;
        public List<Empleados> Empleados { get { return _Empleados; } }

        #region MOSTRAR TODOS
        //M0STRAR
        public void get()
        {
            //List<Empleados> lista = new List<Empleados>();
            //lista.AddRange(from o in Empleados select o);
            ImprimirEmpleados.ImprimirEmpleado(Empleados);
        }
        #endregion

        #region MOSTRAR X ID
        public void getbyId(int id)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.IdEmpleado == id orderby o.IdEmpleado descending select o);
            if (lista.Count > 0)
            {
                ImprimirEmpleados.ImprimirEmpleado(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nuestra BD");
            }

        }
        #endregion 

        #region AGREGAR REGISTROS
        public void post(int id, string nombre, string apellido,
            string direccion, int telefono, DateTime fecha, int idarea)
        {
            var verificarId = Empleados.Any(i => i.IdEmpleado == id);
            if (!verificarId)
            {
                Empleados.Add(new Empleados()
                {
                    IdEmpleado = id,
                    NombreEmpleado = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono,
                    Fecha_ingreso = fecha,
                    IdArea = idarea
                });
                Console.WriteLine("201");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }
        }
        #endregion

        #region ACTUALIZAR
        public void update(int id, string nombre, string apellido,
            string direccion, int telefono, DateTime fecha, int idarea)
        {
            var ReplaceItem = new Empleados
            {
                IdEmpleado = id,
                NombreEmpleado = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Telefono = telefono,
                Fecha_ingreso = fecha,
                IdArea = idarea
            };
            var element = Empleados.FirstOrDefault(i => i.IdEmpleado == ReplaceItem.IdEmpleado);
            if (element != null)
            {
                Empleados.Remove(element);
                Empleados.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }
        }
        #endregion Update

        #region ELIMINAR
        public void DeletexId(int id)
        {
            var element = Empleados.FirstOrDefault(i => i.IdEmpleado == id);
            if (element != null)
            {
                Empleados.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }
        }
        #endregion
    }
}
