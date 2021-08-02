using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, respuesta1, respuesta2;
            Console.WriteLine("Ingrese el primer valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            b = int.Parse(Console.ReadLine());
            respuesta1 = (a + b) * (a - b);
            respuesta2 = a * 2 - b;
            Console.WriteLine("Respuesta 1 (a + b) * (a - b) = " + respuesta1);
            Console.WriteLine("Respuesta 2 de a * 2 - b = " + respuesta2);
            Console.ReadKey();

        }
    }
}
