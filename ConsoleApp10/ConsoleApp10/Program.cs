using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i;
            x = 4;
            y = x + 2;

            for (i = 0; i < x; i++)
            {
                Console.Write(x + " " + y);
                y = y + i;
            }

        }
    }
}
