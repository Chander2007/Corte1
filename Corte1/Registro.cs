using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1
{
    public class Registro
    {
        private List<Persona> personas;

        public Registro()
        {
            personas = new List<Persona>();
        }

        public bool AgregarPersona(Persona persona)
        {
            if (personas.Count < 30)
            {
                personas.Add(persona);
                return true; // Persona agregada correctamente
            }
            else
            {
                return false; // No se pudo agregar, el registro está lleno
            }
        }

        public List<Persona> ObtenerPersonas()
        {
            return new List<Persona>(personas); // Retornar una copia de la lista
        }
    }
}