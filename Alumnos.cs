using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioHerencia1
{
    public class Alumnos : Persona
    {
        public string NoCarnet{ get; set; }
        public List<int> Notas { get; set; }

    }
}