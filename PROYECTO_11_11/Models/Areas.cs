using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PROYECTO_11_11.Models
{
    public class Areas
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
