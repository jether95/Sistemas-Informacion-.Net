using System;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos numeros desea generar: ");
            var size = int.Parse(Console.ReadLine());
            int fibonacci = 0;
            int iterador1 = 1;
            int iterador2;

            for (int i = 0; i < size; i++)
            {
                iterador2 = fibonacci;
                fibonacci = iterador1 + fibonacci;
                iterador1 = iterador2;
                Console.WriteLine(iterador1);
            }

            Console.WriteLine(iterador1 + " es primo: " + primeNumber(iterador1));
        }

        public static Boolean primeNumber(int numberToEvaluate){
            if (numberToEvaluate <= 1)
            {
                return false;
            }

            int count = 0;

            for (int i = (int)Math.Sqrt(numberToEvaluate); i > 1; i--)
            {
                if (numberToEvaluate % i == 0)
                {
                    count++;
                }
            }

            return count < 1;
        }


    }
}
