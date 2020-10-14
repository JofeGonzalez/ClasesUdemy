using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDiaEstudio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ingrese el primer numero: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            float b = float.Parse(Console.ReadLine());
            float resultado = a + b;
            Console.WriteLine("La suma es: " + resultado);
            Console.ReadLine();
            */

            /*
            Console.WriteLine("Ingrese la base del triangulo: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            float b = float.Parse(Console.ReadLine());
            float resultado = (a * b)/2;
            Console.WriteLine("El area es: " + resultado);
            Console.ReadLine();
            */
            /*
            Console.WriteLine("Ingrese el precio del producto: ");
            float a = float.Parse(Console.ReadLine());
            float resultado = (a - ((a * 20) / 100));
            Console.WriteLine("El precio con el 20% de descuento es: " + resultado);
            Console.ReadLine();
            */

            /*
            Console.WriteLine("Ingrese la edad de la persona: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 18)            
                Console.WriteLine("Es menor de edad");           
            else            
                Console.WriteLine("Es mayor de edad");            
            */

            /*
            Console.WriteLine("Ingrese el sueldo del trabajador: ");
            float sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la categoria del trbajador: ");
            string categoria = Console.ReadLine();
            int porcentaje;
            switch (categoria)
            {
                case "a": porcentaje = 20; break;
                case "b": porcentaje = 25; break;
                case "c": porcentaje = 30; break;
                default: porcentaje = 10; break;
            }
            float sueldoTotal = (sueldo + ((sueldo * porcentaje) / 100));
            Console.WriteLine("El sueldo total del trabajador es: " + sueldoTotal);
            Console.ReadLine();
            */

            /*
            int numero = 1;
            while(numero > 0)
            {
                Console.WriteLine("Ingrese el numero: ");
                numero = int.Parse(Console.ReadLine());
                if(numero < 0)
                {
                    break;
                }
                if(numero%2 == 0)
                {
                    Console.WriteLine("El numero es par");
                } else
                {
                    Console.WriteLine("El numero es impar");
                }
            }
            Console.ReadLine();
            */

            /*
            int numero;
            do
            {
                Console.WriteLine("Ingrese el numero: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero > -1);
            */

            /*
            Console.WriteLine("Ingrese la tabla a calcular: ");
            int tabla = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero hasta el cual se va a calcular: ");
            int limite = int.Parse(Console.ReadLine());
            for (int i = 0; i < limite + 1; i++)
            {
                int resultado = tabla * i;
                Console.WriteLine(resultado);
            }
            Console.ReadLine();
            */


        }
    }
}
