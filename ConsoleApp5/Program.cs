using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        int level = 0;
        
        DrawStartScreen(ref level,100,0);
        Console.Write(Console.CursorTop);
        DrawRectangle(2, 0, 8);
        Console.ReadLine();




       



    }

    public static void DrawStartScreen(ref int level, int x, int y)
    {
        String Title = @"
                ____        _   _   _      ____  _     _           
               | __ )  __ _| |_| |_| | ___/ ___|| |__ (_)_ __  ___ 
               |  _ \ / _` | __| __| |/ _ \___ \| '_ \| | '_ \/ __|
               | |_) | (_| | |_| |_| |  __/___) | | | | | |_) \__ \
               |____/ \__,_|\__|\__|_|\___|____/|_| |_|_| .__/|___/
                                                      |_|        
";
        Console.SetCursorPosition(x, y);
        Console.Write(Title);
    }


    public static void DrawRectangle(int cellHeight, int currentPos_x, int currentPos_y)
    {
        int cellWidth = 2 * cellHeight;

        Console.BackgroundColor = ConsoleColor.Red;

        for (int y = 0; y < cellHeight; y++)
        {
            for (int x = 0; x < cellWidth; x++)
            {
                Console.SetCursorPosition(currentPos_x+x,currentPos_y+y);
                Console.Write(" ");
            }
        }
        Console.ResetColor();
    }

}
