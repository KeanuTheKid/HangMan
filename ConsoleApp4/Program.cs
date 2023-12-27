namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                for (int i = 0; i < 11; i++)
                {
                    Console.SetCursorPosition(30+i, 3+i);

                    Console.Write(" ");
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(30-i, 3+i);

                    Console.Write(" ");
                }

                Console.ForegroundColor = ConsoleColor.White;
                for (int x = 0; x < 10; x++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(20+i*2,10+x);

                        Console.Write(" ");
                    }
                }


                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}