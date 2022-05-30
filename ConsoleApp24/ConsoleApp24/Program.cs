using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
            }

            int quantidadeDePares = 0;
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    quantidadeDePares++;
                }
            }
            Console.WriteLine(quantidadeDePares);
        }
    }
}
