using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaOfTriangle();
            CalculateTemperature();
            CalculateAverageOfClassroom();
            CalculateAreaOfCircle();
            GetLargestNumberAndAverage();
        }

        #region AreaOfRightAngledTriangle
        //Calculate the area of a right angled triangle based on the user's input.   Formula is 1/2 base * height
        public static void AreaOfTriangle()
        {
            Console.WriteLine("Here we will work the area of a right angled triangle");
            Console.ReadLine();
            Console.Write("Please input the triangle base: ");
            float triangleBase = float.Parse(Console.ReadLine());
            Console.Write("Please input the triangle lenght: ");
            float triangleLength = float.Parse(Console.ReadLine());

            float triangleArea = (triangleBase* 0.5f) * triangleLength;
            Console.WriteLine("The calculated area of a right angled triangle is {0}", triangleArea);
            Console.ReadLine();
        }
        #endregion

        #region CalculateTemperature
        /*Calculate the average temperature over a week.  
        You need to ask the user for the temperature from Monday to Friday.  
        Afterwards calculate the average which is the total temperature division by the number of days
        */
        public static void CalculateTemperature()
        {
            List<float> temperatureWeek = new List<float>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter temperature for day : " + i);
                temperatureWeek.Add(float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The average total temperature for the week is: {0}", CalculateAverage(temperatureWeek));
            Console.ReadLine();
        }
        #endregion

        #region CalculateAverageAgeOfClassroom
        //Calculate the average age of all the students in the classroom
        public static void CalculateAverageOfClassroom()
        {
            List<float> childerenInClass = new List<float>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter age for pupil " + i);
                childerenInClass.Add(float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The average age of pupils in the class is: {0}", CalculateAverage(childerenInClass));
            Console.ReadLine();
        }
        #endregion

        #region CalculateAreaOfCircle
        //Calculate the area of a circle (Mathf.Pi gives Pi, use the formula Pi * radius * radius)
        public static void CalculateAreaOfCircle()
        {
            Console.WriteLine("We will work out the area of a circle");
            Console.ReadLine();
            Console.Write("Please enter the radius: ");
            float radius = float.Parse(Console.ReadLine());

            double circleArea = Math.PI * radius * radius;
            Console.WriteLine("The are of the circle is: {0}", circleArea);
            Console.ReadLine();
        }
        #endregion

        #region GetLargestNumberAndAverage
        /*Enter five numbers.  Output the largest number, 
        the smallest number and the average number out of all these numbers.
        */
        public static void GetLargestNumberAndAverage()
        {
            List<float> numbersList = new List<float>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter value for number " + i);
                numbersList.Add(float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The maximum value from the numbers list is: {0}", numbersList.Max());
            Console.ReadLine();

            Console.Write("The average number of the list is: {0}", CalculateAverage(numbersList));
            Console.ReadLine();
        }
        #endregion

        /// <summary>
        /// This method will work out the average
        /// </summary>
        /// <param name="myData">Pass a list of floats that contains your data</param>
        /// <returns></returns>
        public static float CalculateAverage(List<float> myData)
        {
            float totalAverage = 0f;

            totalAverage = (myData.Sum() / myData.Count());

            return totalAverage;
        }
    }
}
        
    

