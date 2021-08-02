using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicionumero3
{
    class Program
    {
        static void Main(string[] args)
        {
          int  entero1, entero2 , t; 
            Console.WriteLine("Ingrese el primer numero entero: ");
            entero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese el segundo numero entero: ");
            entero2 = Convert.ToInt32(Console.ReadLine());
            if (entero1 != 0 && entero2 != 0)
            {
                t = entero1 / entero2;
                Console.WriteLine("La repuesta es =" + t);

            }
            else
                Console.WriteLine("Error, no se puede dividir entre 0 " );
            Console.ReadLine();
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
       }
    }


}




