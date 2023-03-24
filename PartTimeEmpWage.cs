using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
    class PartTimeEmpWage
    {
        // Class variable
        private static int wagePerHour = 20;

        // Instance variables
        private int hoursWorked;
        private bool isPartTime;

        // Method to calculate the daily wage
        private int CalculateWage()
        {
            return hoursWorked * wagePerHour;
        }

        // Method to display the daily wage
        public void DisplayWage()
        {
            Console.WriteLine("Employee worked for {0} hours and earned ${1}", hoursWorked, CalculateWage());
        }

        // Method to set the number of hours worked
        public void SetHoursWorked(int hours)
        {
            hoursWorked = hours;
        }

        // Method to set the employee as part-time
        public void SetIsPartTime(bool partTime)
        {
            isPartTime = partTime;
        }

        // Method to check if the employee is part-time
        public bool IsPartTime()
        {
            return isPartTime;
        }
    }
}
