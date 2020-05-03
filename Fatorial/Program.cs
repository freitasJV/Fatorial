using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número para calcular o seu fatorial: ");
                int x = int.Parse(Console.ReadLine());

                int resultado = Fatorial(x);

                Console.WriteLine(resultado);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
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
