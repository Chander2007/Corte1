using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1
{
    internal class Operación
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
                edad--;
            return edad;
        }

        public static bool EsMayorDeEdad(int edad)
        {
            return edad >= 18;
        }
    }
}
