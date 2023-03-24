using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
     class Employee
    {
        // Class variable
        private static Random random = new Random();

        // Instance variable
        private bool present;

        // Method to generate random attendance
        private void CheckAttendance()
        {
            int attendance = random.Next(2);
            present = (attendance == 0) ? false : true;
        }

        // Method to display attendance status
        public void DisplayAttendance()
        {
            CheckAttendance();
            if (present)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
