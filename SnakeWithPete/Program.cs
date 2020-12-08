using System;
using System.Text;

namespace SnakeWithPete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //NOTES: to get special chars
            int xPos = 35;
            int yPos = 20;
            bool started = true;
            bool hitWall = false;

            //Get snake to appear on screen
            //NOTES: Console.WriteLine('\u0047'); // unicode 'G'
            //NOTES: Console.WriteLine((char)0x47); // hex  'G'
            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)9786); // hex '☺'

            //Build Walls
            BuildWall();

            // Get Snake to move
            //NOTES: Do while loops- It runs at least 1 time 
            //NOTES: While(true) loops- it checks if its true before running codeblock
            ConsoleKey command = Console.ReadKey().Key;

            do
            {
                switch (command)
                {
                    //NOTES: Make head move left, remove Head, move cursor position to left side (1 step)
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(" ");
                        xPos--;
                        break;

                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(" ");
                        yPos--;
                        break;

                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(" ");
                        xPos++;
                        break;

                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(xPos, yPos);
                        Console.Write(" ");
                        yPos++;
                        break;
                }

                Console.SetCursorPosition(xPos, yPos);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine((char)9786);

            } while (started);
            // Detect wall 
            //Slow game down
            hitWall = DidSnakeHitWall(xPos, yPos);
            
            Console.ReadLine();
        }

        private static bool DidSnakeHitWall(int xPos, int yPos)
        {
            if (xPos == 1 || xPos == 70 || yPos == 1 || yPos == 31) return true; return false;
        }

        private static void BuildWall()
        {
            //left and Right side wall
            for (int i = 1; i < 31; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, i);
                Console.Write("#");
                Console.SetCursorPosition(70, i);
                Console.Write("#");
            }
            // Top and Bottom side of wall
            for (int i = 1; i < 70; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("#");
                Console.SetCursorPosition(i, 30);
                Console.Write("#");
            }
        }
    }
}
