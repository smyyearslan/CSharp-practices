using System;

namespace consoleApp
{
    class Grade
    {
        static void Main(string[] args)
        {
            int midterm1 = Convert.ToInt32(Console.ReadLine());
            int midterm2 = Convert.ToInt32(Console.ReadLine());
            int final = Convert.ToInt32(Console.ReadLine());

            int score = (midterm1 + midterm2 + final)/3 ;

            switch (score)
            {
                case >= 0 and <30 :
                    Console.WriteLine("1");
                    break;
                case >= 30 and < 60 :
                    Console.WriteLine("2");
                    break;
                case >= 60 and < 100 :
                    Console.WriteLine("3");
                    break;
            }
        }
    }
}