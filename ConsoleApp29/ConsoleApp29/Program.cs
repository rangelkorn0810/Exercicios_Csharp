using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] MxN;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);
            MxN = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    MxN[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (MxN[i, j] < 0)
                    {
                        Console.WriteLine(MxN[i, j]);
                    }
                }
            }
        }
    }
}
