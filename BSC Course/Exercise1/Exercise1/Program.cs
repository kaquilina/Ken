using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "";
            int age = 0;
            float length = 0f;
            float breadth = 0f;
            float area = 0f;
            float currentTemperature = 0f;

            #region Name input
            Console.WriteLine("Please enter your name:");
            myName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine(myName + " " + age);
            Console.ReadLine();
            #endregion

            #region Calculating Area
            string choice = "";

            Console.WriteLine("Would you like to calculate area for Square or Triangle?" + "\n" + " For square enter S and for triangle enter T");
            choice = Console.ReadLine();

            if (choice == "s" || choice == "t")
            {

                if (choice == "s")
                {
                    Console.WriteLine("Please enter the lenght:");
                    length = float.Parse(Console.ReadLine());



                    area = length * 4;
                    Console.WriteLine("The area is: " + area.ToString());
                    Console.ReadLine();

                    if (area > 1000)
                    {
                        Console.WriteLine("Your square is large");
                        Console.ReadLine();
                    }
                    else
                    {
                        if (area < 100)
                        {
                            Console.WriteLine("Your square is small");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    if (choice == "t")
                    {
                        Console.WriteLine("Please enter the breadth");
                        breadth = float.Parse(Console.ReadLine());

                        area = length * breadth;
                        Console.WriteLine("The area for a triangle is: " + area.ToString());
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Your input is not correct!");
                Console.ReadLine();
            }

            #endregion

            #region calculating temperature
            Console.Write("Please enter the current temperature: ");
            currentTemperature = float.Parse(Console.ReadLine());

            if (currentTemperature < 10f)
            {
                Console.WriteLine("It is very cold");
            }

            if (currentTemperature > 30f)
            {
                Console.WriteLine("It is very warm");
            }
            #endregion
        }
    }
}
