
using Programa_4_Herencias.Core;
using Programa_4_Herencias.Entities;

namespace Programa_4_Herencias
{
    internal class Program
    {
        static void Main() { 
        
            Persona persona = new Persona();
            Empleado empleado = new Empleado();

            persona.Nombre = "Juan";
            persona.Edad = 20;

            persona.imprimirNombre();

            empleado.Nombre = "Pedro";
            empleado.Edad = 25;
            empleado.Sueldo = 50000.00;

            empleado.imprimirNombre();
            empleado.imprimirSueldo();

        }

    }
}
