using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static int MostrarCuadrado(int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número y se desplegará su cuadrado: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: "+ MostrarCuadrado(a));
            
        }
    }
}
