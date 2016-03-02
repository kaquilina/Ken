using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle();

            foreach (object o in myRectangle.constructRectangle(10, 20))
            { Console.WriteLine(o); }
            Console.ReadLine();

            //Console.Write("Enter the width: ");
            //myRectangle.width = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the heigth :");
            //myRectangle.heigth = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Area is: " + myRectangle.WorkArea());
            //Console.ReadLine();
        }
    }
}
