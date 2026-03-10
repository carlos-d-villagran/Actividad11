using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        
        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Indique su nombre");
            string nombre = Console.ReadLine();
            Saludar(nombre);
        }
    }
}
