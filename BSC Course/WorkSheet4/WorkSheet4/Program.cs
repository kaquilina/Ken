using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSheet4
{
    class Program
    {
        static void Menu()
        {

        }
        
        static List<Classroom> classrooms = new List<Classroom>();
        
        static void Main(string[] args)
        {
            populateSomeData();
            MainMenu();
        }
        
        /// <summary>
        /// This method lists all the classrooms
        /// </summary>
        /// <param name="classrooms">input needed is an array of classrooms</param>
        public static void ListAllClassRooms()
        {
            foreach (Classroom c in classrooms)
            {
                if (c != null)
                {
                    Console.WriteLine("\n " + c.ClassroomName);
                    Console.Write("\n");
                }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This method adds a new classroom
        /// </summary>
        /// <param name="className">The name for the new classroom</param>
        /// <param name="projectorAvailable">True if projector available, false if not</param>
        /// <param name="noOfComputers">The number of computers</param>
        public static void AddClassroom()
        {
            Console.Write("Enter a name for the new classroom: ");
            string className = Console.ReadLine();
            Console.Write("Is a projector available? (Yes/No): ");
            string projectorAvailable = Console.ReadLine();
            Console.Write("How many computers will this classroom have?: ");
            int noOfComputers = Convert.ToInt32(Console.ReadLine());
            
            List<string> newClassroom = new List<string>();
            List<Computer> computers = new List<Computer>();
           
            for (int i = 0; i < noOfComputers; i++)
            {
                Computer tempComputerInstance = new Computer(className + "-PC" +i, "OK", 0);
                computers.Add(tempComputerInstance);
            }

            Classroom myNewClassroom = new Classroom(className, returnProjectorData(projectorAvailable), computers);
            
                classrooms.Add(myNewClassroom);
                Console.Write("Class: {0} has been added", className);
                Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
        
        /// <summary>
        /// This method will add new computers to a classroom
        /// </summary>
        /// <param name="className">Name of the classroom in which you want to add new computers</param>
        /// <param name="computerName">Computer name desired</param>
        /// <param name="noOfNewComputers">The number of new computers to add</param>
        public static void AddNewComputers()
        {
            Console.Write("Enter the classroom name where computers will be added: ");
            string className = Console.ReadLine();
            Console.Write("Enter the name for the new computers: ");
            string computerName = Console.ReadLine();
            Console.Write("How many computers would you like to add?: ");
            int noOfNewComputers = Convert.ToInt32(Console.ReadLine());
            
            List<Computer> newComputers = new List<Computer>();

            for (int i = 0; i < noOfNewComputers; i++)
            {
                Computer tempComputerInstance = new Computer(computerName + "-PC" + i, "OK", 0);
                newComputers.Add(tempComputerInstance);
            }
            foreach (Classroom c in classrooms)
            {
                if (c.ClassroomName == className)
                {
                    c.ComputersInClassroom.AddRange(newComputers);
                }
            }

            foreach (Classroom c in classrooms)
            {
                if (c != null)
                {
                    Console.Write(c);
                    Console.Write("\n");
                }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This method updates the computer status
        /// </summary>
        public static void UpdateComputerStatus()
        {
            Console.Write("Enter the computer name which status you would like to update: ");
            string computerName = Console.ReadLine();
            Console.Write("Enter the new status: ");
            string newComputerStatus = Console.ReadLine();

            foreach (Classroom c in classrooms)
            {
                foreach (Computer comp in c.ComputersInClassroom)
                {
                    if (comp.ComputerName == computerName)
                    {
                        comp.ComputerStatus = newComputerStatus;
                        comp.NoOfFaults++;

                        Console.WriteLine("\n Status has been updated");
                        Console.ReadLine();
                    }
                }
            }
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This method will list all the computers in a class ordered by faults
        /// </summary>
        public static void ListComputersInClassOrderedByFaults()
        {
            Console.Write("Please enter the name of the classroom to order by computer faults: ");
            string className = Console.ReadLine();

            foreach (Classroom c in classrooms)
            {
                if (c.ClassroomName == className)
                {
                    List<Computer> myTempComputerList = new List<Computer>(c.ComputersInClassroom);

                    List<Computer> SortedList = myTempComputerList.OrderBy(o => o.ComputerStatus).ToList();

                    foreach (Computer comp in SortedList)
                    {
                        Console.WriteLine("\n " + comp);
                    }
                }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This method will list all the computers
        /// </summary>
        public static void ListAllComputers()
        {
            foreach (Classroom c in classrooms)
            {
                if (c != null)
                {
                    Console.WriteLine("\n " + c);
                    Console.Write("\n");
                }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This method allows the user to search for a classroom
        /// </summary>
        public static void SearchForClassroom()
        {
            Console.Write("Enter the name of the classroom you would like to search for: ");
            string classNameToSearch = Console.ReadLine();

            foreach (Classroom c in classrooms)
            {
                if (c.ClassroomName == classNameToSearch)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(c);
                }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();                
        }

        /// <summary>
        /// This method allows the user to search for a computer
        /// </summary>
        public static void SearchComputer()
        {
            Console.Write("Enter the name of the computer you would like to search for: ");
            string computerNameToSearch = Console.ReadLine();

            foreach (Classroom c in classrooms)
            {
                foreach (Computer comp in c.ComputersInClassroom)
                    if (comp.ComputerName == computerNameToSearch)
                    {
                        Console.Write(comp);
                        break;
                    }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This method deletes a computer
        /// </summary>
        public static void DeleteComputer()
        {
            Console.Write("Enter the name of the computer you would like to delete: ");
            string computerNameToDelete = Console.ReadLine();

            foreach (Classroom c in classrooms)
            {
                foreach(Computer comp in c.ComputersInClassroom)
                if (comp.ComputerName == computerNameToDelete)
                {
                        c.ComputersInClassroom.Remove(comp);
                        Console.Write(computerNameToDelete + " has been deleted!");
                        break;
                    }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This method deletes a classroom
        /// </summary>
        public static void DeleteClassroom()
        {
            Console.Write("Please enter the name of the classroom you would like to delete: ");
            string classNameToDelete = Console.ReadLine();
            
            foreach (Classroom c in classrooms)
            {
                if (c.ClassroomName == classNameToDelete)
                {
                    classrooms.Remove(c);
                    Console.Write(classNameToDelete + " has been deleted!");
                    break;
                }
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        /// <summary>
        /// This is the main menu
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("\n [1] List All Classrooms in the system \n [2] Add new classroom \n [3] Add new computers \n [4] List all computers in the system \n [5] Update Computer Status \n [6] List all computers in classroom ordered by faults \n [7] Search for classroom \n [8] Delete Classroom \n [9] Search Computer \n [10] Delete Computer \n [11] Quit");
            Console.Write("\n Enter Choice: ");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    ListAllClassRooms();
                    break;
                case 2:
                    AddClassroom();
                    break;
                case 3:
                    AddNewComputers();
                    break;
                case 4:
                    ListAllComputers();
                    break;
                case 5:
                    UpdateComputerStatus();
                    break;
                case 6:
                    ListComputersInClassOrderedByFaults();
                    break;
                case 7:
                    SearchForClassroom();
                    break;
                case 8:
                    DeleteClassroom();
                    break;
                case 9:
                    SearchComputer();
                    break;
                case 10:
                    DeleteComputer();
                    break;
                case 11:
                    break;
            }
        }

        /// <summary>
        /// This method populates some initial data
        /// </summary>
        public static void populateSomeData()
        {
            //Computer[] computers = new Computer[20];
            List<Computer> computers = new List<Computer>();

            //Classroom1
            Computer classroom1PC1 = new Computer("Classroom1-PC0", "OK", 8);
            Computer classroom1PC2 = new Computer("Classroom1-PC1", "OK", 100);
            Computer classroom1PC3 = new Computer("Classroom1-PC2", "NOT OK", 3);
            //Computer[] classroom1Computers = new Computer[20];
            List<Computer> classroom1Computers = new List<Computer>();
            classroom1Computers.Add(classroom1PC1);
            classroom1Computers.Add(classroom1PC2);
            classroom1Computers.Add(classroom1PC3);
            Classroom classroom1 = new Classroom("Classroom1", true, classroom1Computers);
            classrooms.Add(classroom1);
            
            
            //Classroom1
            Computer classroom2PC1 = new Computer("Classroom2-PC0", "OK", 0);
            Computer classroom2PC2 = new Computer("Classroom2-PC1", "OK", 0);
            Computer classroom2PC3 = new Computer("Classroom2-PC2", "NOT OK", 3);
            //Computer[] classroom2Computers = new Computer[20];
            List<Computer> classroom2Computers = new List<Computer>();
            classroom2Computers.Add(classroom2PC1);
            classroom2Computers.Add(classroom2PC2);
            classroom2Computers.Add(classroom2PC3);
            Classroom classroom2 = new Classroom("Classroom2", true, classroom2Computers);
            classrooms.Add(classroom2);
        }

        /// <summary>
        /// This method returns the projector data
        /// </summary>
        /// <param name="userInput">expectes user input in string</param>
        /// <returns>return true if yes, and false if no</returns>
        public static bool returnProjectorData(string userInput)
        {
            if (userInput == "Y" || userInput == "Yes" || userInput == "yes")
            { return true; }
            else
            {
                if (userInput == "N" || userInput == "No" || userInput == "no")
                { return false; }
                return false;
            }
        }
       
    }
}
