using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculo_IVA
{
    class Program
    {
        static Operacion o = new Operacion();
        static void Main(string[] args)
        {
            string nombre;
            string nit;
            char menu = 'n';
            double Sub1;
            string pro1;
            double pre1;
            int cant1;
            string linea;
            int total;

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese nit: ");
            nit = Console.ReadLine();

            Sub1 = 0;

            while (menu != 'n') ;
            {
                Console.Write("Ingrese nombre del producto: ");
                pro1 = Console.ReadLine();

                Console.Write("Ingrese precio del producto: ");
                linea = Console.ReadLine();
                pre1 = double.Parse(linea);

                Console.Write("Ingrese cantidad del producto: ");
                linea = Console.ReadLine();
                cant1 = int.Parse(linea);

                Sub1 = Sub1 + (pre1 + cant1);

                Console.Write("¿Desea agregar otro producto?: ");
                menu = char.Parse(linea);

                total = Sub1.o(IVA);

            }
            Console.WriteLine("El total de la compra es: +total");
        }
    }
}
