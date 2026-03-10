using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static int MostrarDoble(int numero)
        {
            return  numero * 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número y se mostrará el doble: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(MostrarDoble(numero));
        }
    }
}
