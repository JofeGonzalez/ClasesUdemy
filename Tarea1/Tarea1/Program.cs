using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de semanas a convertir: ");
            int semanasConvertir = int.Parse(Console.ReadLine());
            int diasConvertidos = semanasConvertir * 7;
            Console.WriteLine("Los dias son: " + diasConvertidos);
            Console.ReadLine();
        }
    }
}
