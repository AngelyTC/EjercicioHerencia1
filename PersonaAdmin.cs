using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioHerencia1
{
    public class PersonaAdmin : Persona
    {
        public string NoIGSS { get; set; }
        public string Profesion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
    }
}