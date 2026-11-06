using System;

namespace consoleApp
{
    class Conversion
    {
        static void Main(string[] args)
        {
            int a = 10;
            long b = a;

            long d = 20;
            int e = (int)d;

            double f = 20.5;
            float g = (float)f;

            double h = 10.5;
            int i = (int)h;

            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(e);
            Console.WriteLine(a);
        }
    }
}