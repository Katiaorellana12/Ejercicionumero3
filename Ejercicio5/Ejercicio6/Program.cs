using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, porcentaje1, porcentaje2, porcentaje3, notafinal;
            Console.WriteLine("Ingrese la primer nota (30%) : ");
            nota1 = int.Parse(Console.ReadLine());
            porcentaje1 = (nota1 * 0.30);
            Console.WriteLine("Su nota ingresa es de : " + nota1);
            Console.WriteLine("Su nota con el 30% es de ; " + porcentaje1);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ingrese la segunda nota (35%) :");
            nota2 = int.Parse(Console.ReadLine());
            porcentaje2 = (nota2 * 0.35);
            Console.WriteLine("Su nota ingresa es de : " + nota2);
            Console.WriteLine("Su nota con el 30% es de ; " + porcentaje2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ingrese la tercera nota (25%) :");
            nota3 = int.Parse(Console.ReadLine());
            porcentaje3 = (nota3 * 0.25);
            Console.WriteLine("Su nota ingresa es de : " + nota3);
            Console.WriteLine("Su nota con el 30% es de ; " + porcentaje3);
            Console.WriteLine("-----------------------------------");
            notafinal = (porcentaje1 + porcentaje2 + porcentaje3);
            Console.WriteLine("La nota final es de: " + notafinal);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pulse una tecla para salir ");
            Console.ReadKey();
        }
    }
}
