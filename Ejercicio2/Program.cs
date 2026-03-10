using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void MostrarNombre(string nombre)
        {
            Console.WriteLine("Bienvenido " + nombre);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrodusca el nombre: ");
            string nombre = Console.ReadLine();
            MostrarNombre (nombre);
        }
    }
}
