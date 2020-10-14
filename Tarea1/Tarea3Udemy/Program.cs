using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el costo del producto: ");
            int costoProducto = int.Parse(Console.ReadLine());
            int productoMasImpuestos = (costoProducto + ((costoProducto*18)/100));
            Console.WriteLine("El producto cuesta: " + productoMasImpuestos);
            Console.ReadLine();
        }
    }
}
