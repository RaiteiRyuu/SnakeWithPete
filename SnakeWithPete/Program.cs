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

            //Get snake to appear on screen
            //NOTES: Console.WriteLine('\u0047'); // unicode 'G'
            //NOTES: Console.WriteLine((char)0x47); // hex  'G'
            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)9786); // hex '☺'

            // Get Snake to move
            //NOTES: Do while loops- It runs at least 1 time 
            //NOTES: While(true) loops- it checks if its true before running codeblock

            do
            {

            } while (true);

            //Build Walls
            BuildWall();
            // Detect wall 

            
            Console.ReadLine();
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
