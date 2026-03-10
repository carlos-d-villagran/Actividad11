using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void ImprimirRepetido(string texto, int veces)
        {
            for (int i = 0; i < veces; i++)
            {
                Console.WriteLine(texto);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Indique el texto a repetir: ");
            string texto = Console.ReadLine();
            Console.WriteLine("Cuantas veces quiere repetirlo: ");
            int veces = int.Parse(Console.ReadLine());
            ImprimirRepetido(texto,veces);
        }
    }
}
