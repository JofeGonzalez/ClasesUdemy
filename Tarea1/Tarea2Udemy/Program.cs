using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de horas de trabajo: ");
            int numeroHoras = int.Parse(Console.ReadLine());
            int sueldoPorHoras = numeroHoras * 20;
            Console.WriteLine("El empleado gana:" + sueldoPorHoras + " soles");
            Console.ReadLine();
        }
    }
}
