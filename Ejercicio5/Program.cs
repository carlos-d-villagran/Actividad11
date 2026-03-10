using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void MostrarMenu()
        {
            Console.WriteLine("++++ Menú de estudiantes ++++");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Modificar");
            Console.WriteLine("3. Desplegar");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
        }
        static void Main(string[] args)
        {
            MostrarMenu();
        }
    }
}
