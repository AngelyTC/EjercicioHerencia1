﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioHerencia1
{
    public class Persona
    {
        public string nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int edad  { get; set; }


        public int Calcular()
        {
            //codigo para calcular algo
            return 1;
        }
    }
}