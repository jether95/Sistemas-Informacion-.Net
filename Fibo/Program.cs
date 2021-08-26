using System;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos numeros desea generar: ");
            var tamaño = int.Parse(Console.ReadLine());
            int fibonacci = 0;
            int iterador1 = 1;
            int iterador2;

            for (int i = 0; i < tamaño; i++)
            {
                iterador2 = fibonacci;
                fibonacci = iterador1 + fibonacci;
                iterador1 = iterador2;
                Console.WriteLine(iterador1);
            }

            Console.WriteLine(iterador1 + " es primo: " + esPrimo(iterador1));
        }

        public static Boolean esPrimo(int numero){
            if (numero <= 1)
            {
                return false;
            }

            int contador = 0;

            for (int i = (int)Math.Sqrt(numero); i > 1; i--)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }

            return contador < 1;
        }


    }
}
