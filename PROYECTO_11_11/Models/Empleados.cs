using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROYECTO_11_11.Models
{
    public class Empleados
    {
        [Key]
        public int IdEmpleado { get; set; }
        [Required(ErrorMessage = "campo Requerido")]
        public string NombreEmpleado { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime Fecha_ingreso { get; set; }

        [ForeignKey("IdArea")]
        public int IdArea { get; set; }
    }
}
