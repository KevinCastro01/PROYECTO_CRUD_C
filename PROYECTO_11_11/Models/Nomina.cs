using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROYECTO_11_11.Models
{
    public class Nomina
    {
        [Key]
        public int Id{ get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("IdEmpleados")]
        public int IdEmpleados { get; set; }
        public int Sueldo { get; set; }
        public int Dias { get; set; }
        public int TotalBasico { get; set; } 
        public int Otros { get; set; }
        public int Devengado { get; set; }
    }
}
