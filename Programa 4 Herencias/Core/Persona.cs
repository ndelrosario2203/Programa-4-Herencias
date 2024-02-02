using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_4_Herencias.Core
{
    internal class Persona
    {

        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public void imprimirNombre() {
            Console.WriteLine("El nombre de esta persona es: " +  Nombre);
        }
    }
}
