using PROYECTO_11_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROYECTO_11_11.Controllers
{
    class NominaControllers
    {
        public NominaControllers()
        {
            _Nomina = new List<Nomina>();
        }

        private List<Nomina> _Nomina;
        public List<Nomina> Nomina { get { return _Nomina; } }

        #region MOSTRAR TODAS
        //M0STRAR
        public void get()
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina select o);
            ImprimirNominas.ImprimirNomina(lista);
        }
        #endregion

        #region BUSCAR X ID
        public void getbyId(int id)
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina where o.Id == id orderby o.Id descending select o);
            if (lista.Count > 0)
            {
                ImprimirNominas.ImprimirNomina(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nuestra BD");
            }

        }
        #endregion getbyid

        #region AGREGAR NUEVO REGISTRO
        public void post(int id, DateTime fecha, int idemple, int sueldo, int dias, int totalbasico, int otros, int devengado)
        {
            var verificarId = Nomina.Any(i => i.Id == id);
            if (!verificarId)
            {
                Nomina.Add(new Nomina()
                {
                    Id = id,
                    Fecha = fecha,
                    IdEmpleados = idemple,
                    Sueldo = sueldo,
                    Dias = dias,
                    TotalBasico = (sueldo * dias) / 30,
                    Otros = otros,
                    Devengado = (otros * dias) / 30
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
        public void update(int id, DateTime fecha, int idemple, int sueldo, int dias, int totalbasico, int otros, int devengado)
        {
            var ReplaceItem = new Nomina
            {
                Id = id,
                Fecha = fecha,
                IdEmpleados = idemple,
                Sueldo = sueldo,
                Dias = dias,
                TotalBasico = (sueldo * dias) / 30,
                Otros = otros,
                Devengado = (otros * dias) / 30
            };
            var element = Nomina.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if (element != null)
            {
                Nomina.Remove(element);
                Nomina.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }
        }
        #endregion Update

        #region ELIMINAR NOMINA
        public void DeletexId(int id)
        {
            var element = Nomina.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Nomina.Remove(element);
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
