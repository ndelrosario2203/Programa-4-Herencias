using Programa_4_Herencias.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Programa_4_Herencias.Entities
{
    internal class Empleado : Persona
    {


        public double Sueldo { get; set; }

        public void imprimirSueldo() {
            Console.WriteLine("El sueldo de esta persona es: " + Sueldo);
        }
    }
}
