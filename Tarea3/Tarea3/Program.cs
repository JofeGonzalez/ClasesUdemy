using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numero = 19;
            while(numero < 38)
            {
                Console.WriteLine(numero);
                numero += 2;
            }
            Console.ReadLine();
            */

            /*
            int numero;
            do
            {
                Console.WriteLine("Ingrese el numero: ");
                numero = int.Parse(Console.ReadLine());
                if(numero < 0)
                {
                    break;
                }
                int numeroDividido = numero / 2;
                Console.WriteLine("El nuevo numero es: " + numeroDividido);
            }while (numero > -1) ;
            Console.ReadLine();
            */

            /*
            int numeroTotal = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                numeroTotal = numeroTotal + numero;
            }
            Console.WriteLine("La suma de los 5 numeros es: " + numeroTotal);
            Console.ReadLine();
            */

            /*
            int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };
            int par = 0;
            int impar = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if(valores[i] %2 == 0)
                {
                    par++;
                } else
                {
                    impar++;
                }
            }
            Console.WriteLine("El numero de numeros pares es: " + par);
            Console.WriteLine("El numero de numeros impares es: " + impar);
            Console.ReadLine();
            */

            /*
            int[] valores = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };
            int contador = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if(valores[i] > 99 && valores[i] < 1000)
                {
                    contador++;
                }
            }
            Console.WriteLine("El numero de numeros de tres cifras es: " + contador);
            Console.ReadLine();
            */

            /*
            int[] números = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };
            int sumaTotal = 0;
            for (int i = 0; i < números.Length; i++)
            {
                if (números[i] > 14)
                {
                    sumaTotal = sumaTotal + números[i];
                }
            }
            Console.WriteLine("La suma es: " + sumaTotal);
            Console.ReadLine();
            */


        }
    }
}
