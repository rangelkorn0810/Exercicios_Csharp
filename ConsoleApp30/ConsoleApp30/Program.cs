using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] NxN;

            N = int.Parse(Console.ReadLine());
            NxN = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; i++)
                {
                    NxN[i, j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; i++)
                {
                    soma = soma + NxN[i, j];
                    Console.WriteLine(soma);
                }
            }
        }
    }
}
