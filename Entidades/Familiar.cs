using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar: Persona
    {

        public DateTime FechaNacimiento { get; set; }


        public int CalcularEdad(DateTime FechaN)
        {
           
            int edad;
            edad = DateTime.Now.Year - FechaNacimiento.Year;

            return edad;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{FechaNacimiento.ToShortDateString()}";
        }

    }
}
