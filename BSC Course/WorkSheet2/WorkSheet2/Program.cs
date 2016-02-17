using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSheet2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        /// <summary>
        /// This is the main menu
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("\n [1] CalculateTimesTable \n [2] CalculateBMI \n [3] CalculateAverageAgeStudentsInClass \n [4] DrawLineOfStars \n [5] CountName \n [6] Quit");
            Console.Write("\n Enter Choice: ");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    CalculateTimesTable();
                    break;
                case 2:
                    CalculateBMI();
                    break;
                case 3:
                    CalculateAverageAgeStudentsInClass();
                    break;
                case 4:
                    DrawLineOfStars();
                    break;
                case 5:
                    CountName();
                    break;
                case 6:
                    break;
            }
        }

        /// <summary>
        /// Creat an application that calculates and ouputs
        /// the times table of a number the user inputs
        /// </summary>
        public static void CalculateTimesTable()
        {
            Console.Write("\n Please enter your choice for the times table: ");
            float timestableUserChoice = (float.Parse(Console.ReadLine()));
            Console.Write("\n");
            float answer = 0f;

            int i = 1;
            while (i < 11)
            {
                answer = i * timestableUserChoice;
                Console.Write(" " + i + "*{0}={1}", timestableUserChoice, answer);
                Console.Write("\n");
                i++;
            }
            Console.ReadLine();

            //for (int i = 1; i < 11; i++)
            //{
            //    answer = i * timestableUserChoice;
            //    Console.Write(i + "*{0}={1}", timestableUserChoice, answer);
            //    Console.ReadLine();
            //}
        }

        /// <summary>
        /// Create an application that calculates your BMI based on weight and height
        /// </summary>
        public static void CalculateBMI()
        {
            float weight = 0f;
            float height = 0f;
            float BMI = 0f;

            Console.Write("\n Please enter your weight in KGs: ");
            weight = float.Parse(Console.ReadLine());
            Console.Write(" Please enter your height in meters: ");
            height = float.Parse(Console.ReadLine());
            
            try
            {
                BMI = weight / (height * height);
                Console.WriteLine(" Your BMI is: {0} and {1}", BMI, getBMIResult(BMI));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error occured while calculating BMI result {0}", e);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Create an application that asks you how many students there are in class, 
        /// then depending on the number of students, 
        /// asks the user to input their age and calculates the average age of the students in the class
        /// </summary>
        public static void CalculateAverageAgeStudentsInClass()
        {
            int noOfStudents = 0;
            List<int> studentAge = new List<int>();

            Console.Write("\n How many Students are there in the class? : ");
            noOfStudents = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < noOfStudents+1; i++)
            {
                Console.Write(" Please enter age for pupil {0}: ",i);
                studentAge.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(" The average age of pupils in the class is: {0}", CalculateAverageAge(studentAge));
            Console.ReadLine();
        }

        /// <summary>
        /// Create an application that draws a line of stars on the screen depending on the user's input
        /// </summary>
        public static void DrawLineOfStars()
        {
            int noOfStars = 0;

            Console.Write("\n How many stars would you like to draw in a line? : ");
            noOfStars = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < noOfStars)
            {
                Console.Write(" *");
                i++;
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This methods counts the number of letters in your name
        /// </summary>
        public static void CountName()
        {
            string name;

            Console.Write("\n Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine(" Your name has {0} characters", name.Length);
            Console.ReadLine();
        }

        //common methods
        /// <summary>
        /// This method gets the BMI result
        /// </summary>
        /// <param name="BMI">the bmi used to determine result</param>
        /// <returns>underweight or normal or overweight or obese</returns>
        public static string getBMIResult(float BMI)
        {
            if (BMI < 18.5)
            {
                return  "You are underweight";
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                return "Your BMI is normal";
            }
            else if (BMI >= 25.0 && BMI <= 29.9)
            {
                return "You are overweight";
            }
            else if (BMI >= 30.0)
            {
                return "You are obese";
            }
            return null;
        }

        /// <summary>
        /// This method will work out the average
        /// </summary>
        /// <param name="myData">Pass a list of floats that contains your data</param>
        /// <returns></returns>
        public static float CalculateAverageAge(List<int> myData)
        {
            float totalAverage = 0f;

            totalAverage = (myData.Sum() / myData.Count());

            return totalAverage;
        }
    }
}
