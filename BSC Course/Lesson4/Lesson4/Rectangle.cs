using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Rectangle
    {
        public int width;
        public int heigth;

        public int WorkArea()
        {
            int result;
            result = width * heigth;
            return result;
        }

        public List<string> constructRectangle(int width, int heigth)
        {
            string display = "";
            List<string> myRec = new List<string>();

            for (int i = 0; i < heigth; i++)
            {
                 myRec.Add(display.PadRight(width, 'x'));
            }
            return myRec;
        }
    }

}
