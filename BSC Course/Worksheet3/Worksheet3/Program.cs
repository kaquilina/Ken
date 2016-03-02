using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        /// <summary>
        /// Create an application that draws a right angle triangle with a base equal to the user input
        /// </summary>
        public static void DrawRightAngledTriangle()
        {
            Console.Clear();
            int trianglebase = 0;

            Console.Write("Please enter a whole number for the triangle base: ");
            trianglebase = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= trianglebase; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Create an application that draws a triangle with the highest
        /// point in the middle and a base double the user input
        /// </summary>
        public static void TriangleHighestPointInMiddle()
        {
            int trianglebase = 0;
            int emptyCharCount = 0;
            string emptyChar = "";
            int fillCharCount = 1;
            string fillChar = "";

            Console.Clear();
            Console.Write("Please enter a whole number for the triangle base: ");
            trianglebase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            emptyCharCount = trianglebase * 2;
            for (int i = 0; i < trianglebase; i++)
            {
                Console.Write(emptyChar.PadRight(emptyCharCount, ' '));
                emptyCharCount--;

                Console.Write(fillChar.PadRight(fillCharCount, '*'));
                fillCharCount++;
                fillCharCount++;
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Create an application that draws a full square based on user input of width and height in Xs
        /// </summary>
        public static void DrawFullSquare()
        {
            int width = 0;
            string display = "";

            Console.Clear();
            Console.Write("Please enter the width of the square: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 0; i < width; i++)
            {
                Console.WriteLine(display.PadRight(width, 'x'));
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Create an application that draws an empty square with just the outer Xs showing
        /// </summary>
        public static void DrawEmptySquare()
        {
            Console.Clear();
            Console.Write("Please enter the width of the square: ");
            int width = Convert.ToInt32(Console.ReadLine());

            //Adding the topline
            for (int i = 0; i < width; i++)
            {
                Console.Write("x");
            }

            //Adding the left and right
            for (int j = 1; j < width - 1; j++)
            {
                //left
                Console.SetCursorPosition(0, j);
                Console.Write("x");
                //right
                Console.SetCursorPosition(width - 1, j);
                Console.Write("x");
            }

            Console.SetCursorPosition(0, width - 1);

            //Adding the last line
            for (int k = 0; k < width; k++)
            {
                Console.Write("x");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Create an application that draws a diagonal line of Xs
        /// </summary>
        public static void DrawDiagonalLine()
        {
            int length = 0;
            string Char = " ";
            int CharCount;

            Console.Clear();
            Console.Write("Please enter the length of the diagonal line to be drawn: ");
            length = Convert.ToInt32(Console.ReadLine());
            CharCount = length;

            for (int i = 0; i < length; i++)
            {
                Console.Write(Char.PadRight(CharCount, ' '));
                Console.Write("x");
                Console.ReadLine();
                CharCount--;
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This is the main menu
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("\n [1] DrawRightAngledTriangle \n [2] TriangleHighestPointInMiddle \n [3] DrawFullSquare \n [4] DrawEmptySquare \n [5] DrawDiagonalLine \n [6] Quit");
            Console.Write("\n Enter Choice: ");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    DrawRightAngledTriangle();
                    break;
                case 2:
                    TriangleHighestPointInMiddle();
                    break;
                case 3:
                    DrawFullSquare();
                    break;
                case 4:
                    DrawEmptySquare();
                    break;
                case 5:
                    DrawDiagonalLine();
                    break;
                case 6:
                    break;
            }
        }
    }
}
 