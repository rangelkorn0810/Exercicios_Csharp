﻿using System;
using System.Globalization;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
          
            N = int.Parse(Console.ReadLine());
                
            double[] vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            double maior = vet[0];
            int posicaoMaior = 0;

            for (int i = 0; i < N; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}
