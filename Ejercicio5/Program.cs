using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio del producto:  ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El producto es medicina? si/no:");
            string iva = Console.ReadLine();
            if (iva == "si" || iva == "SI")
            {
                Console.WriteLine("El productos es medicina asi que no se le cobra impuestos, el precio es: {0}", precio);
            }
            else if (iva == "no" || iva == "NO")
            {
                double precio_porcentaje;
                precio_porcentaje = precio * 13.00 / 100;

                double precio_final;
                precio_final = precio + precio_porcentaje;

                Console.WriteLine("El precio con IVA es: {0}", precio_final);

            }
            else
            {
                Console.WriteLine("La respuesta de, si el producto era medicina o no, no es valida");
            }

            Console.ReadKey();
        }
    }
}
