using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSheet4
{
    class Classroom
    {
        string _classroomName;
        bool _projectorAvailable;
        
        List<Computer> _computersInClassroom;

        public string ClassroomName
        {
            get { return _classroomName; }
            set { _classroomName = value; }
        }

        internal List<Computer> ComputersInClassroom
        {
            get
            {
                return _computersInClassroom;
            }

            set
            {
                _computersInClassroom = value;
            }
        }

        public bool ProjectorAvailable
        {
            get
            {
                return _projectorAvailable;
            }

            set
            {
                _projectorAvailable = value;
            }
        }

        public Classroom(string classroomName, bool projectorAvailable, List<Computer> allComputersInClass)
        {
            ClassroomName = classroomName;
            ProjectorAvailable = projectorAvailable;
            ComputersInClassroom = allComputersInClass;
        }

        public Classroom(List<Computer>  allComputersInClass)
        {
            ComputersInClassroom = allComputersInClass;
        }
        public Classroom()
        { }

        /// <summary>
        /// This will override the .toString method of C#
        /// </summary>
        /// <returns>Will return a string with classroom name and projector</returns>
        override
        public string ToString()
        {
            string output = "";
            output += "Name of Classroom: " + ClassroomName + " Projector: " + displayProjectorData(ProjectorAvailable) + "\n";
            foreach (Computer c in ComputersInClassroom)
            {
                if(c != null)
                output += c;
            }
            return output;
        }

        public static string displayProjectorData(bool projectorData)
        {
            if (projectorData == true)
            { return "Yes"; }
            return "No";
        }

    }
}
