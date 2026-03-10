using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static int Sumar(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer sumando: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo sumando: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + Sumar(a,b));
        }
    }
}
