using System;

namespace MyCompiler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Quiz();
        }

        static void Quiz()
        {
            Random rand = new Random();
            int score = 0;
            int errors = 3;

            while (true)
            {
                int a = rand.Next(1, 6);
                int b = rand.Next(1, 6);
                int c=0;
                string OP="";
                Console.Clear();
                Console.WriteLine("lifes: "+errors);
                
                int operation = rand.Next(1, 4);
                if(operation == 1) {
                    c = a+b;
                    OP = "+";
                }

                else if(operation == 2) {
                    c=a-b;
                    OP = "-";
                }

                else if(operation == 3) {
                    c=a*b;
                    OP = "*";
                }

                else if(operation == 4) {
                    c=a/b;
                    OP = "/";
                }

                Console.WriteLine("was ergibt " + a + OP + b +"?");
                Console.WriteLine("your score: " + score);
                   
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    if (result == c)
                    {
                        score++;
                    }
                    else
                    {
                        
                        errors--;
                        
                    }

                    // Add an exit condition if needed, for example:
                    if (errors <= 0) // Exit if 3 errors occur
                     {
                        Console.Clear() ;   
                        Console.WriteLine("Exiting the quiz.");
                        Console.WriteLine("Your score was: " + score);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            
        }
    }
}
