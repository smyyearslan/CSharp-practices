using System;

namespace consoleApp
{
    class IfElse
    {
        static void Main(string[] args)
        {
            string username = "smyyearslann";

            if(username == "smyyearslann")
            {
                Console.WriteLine("enter password");
                string password = Console.ReadLine();

                if(password == "123456")
                {
                    Console.WriteLine( "Welcome!");
                }
                else
                {
                    Console.WriteLine("wrong password");
                }
            }
            else
            {
                Console.WriteLine("wrong username");
            }

        }
    }
}