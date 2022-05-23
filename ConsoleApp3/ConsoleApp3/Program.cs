using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0) { 
            

                Console.WriteLine("sao multiplos");
            }
            else {

                Console.WriteLine("nao sao multiplos"); }

            
        }
    }
}
