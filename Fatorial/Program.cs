using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular o seu fatorial: ");
            int x = int.Parse(Console.ReadLine());

            int resultado = Fatorial(x);

            Console.WriteLine(resultado);
        }

        static int Fatorial(int n)
        {
            if (n == 0)
                return 0;
            if (n <= 1)
                return n;
            else
                return n * Fatorial(n - 1);
        }
    }
}
