using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSheet4
{
    class Computer
    {
        string _computerName;
        string _computerStatus;
        int _noOfFaults;

        public string ComputerName
        {
            get
            {
                return _computerName;
            }

            set
            {
                _computerName = value;
            }
        }

        public string ComputerStatus
        {
            get
            {
                return _computerStatus;
            }

            set
            {
                _computerStatus = value;
            }
        }

        public int NoOfFaults
        {
            get
            {
                return _noOfFaults;
            }

            set
            {
                _noOfFaults = value;
            }
        }

        public Computer(string computerName, string computerStatus, int noOfFaults)
        {
            ComputerName = computerName;
            ComputerStatus = computerStatus;
            NoOfFaults = noOfFaults;
        }

        override
        public string ToString()
        {
            string output = "";
            output =  "================================================\n";
            output += " Computer Name : " + ComputerName + "\n";
            output += " Computer Status : " + ComputerStatus + "\n";
            output += " No of Faults : " + NoOfFaults + "\n";
            output += "================================================\n";
            return output;
        }
    }
}
