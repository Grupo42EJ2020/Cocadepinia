using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public class Cursos
    {
        public int IdCursos { get; set; }
        public string Descripcion { get; set; }
        public int IdEmpleado { get; set; }
    }
}