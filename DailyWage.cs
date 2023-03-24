using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
     class DailyWage
    {
        // Class variable
        private static int wagePerHour = 20;

        // Instance variable
        private int hoursWorked;

        // Method to calculate the daily wage
        private int CalculateWage()
        {
            return hoursWorked * wagePerHour;
        }

        // Method to display the daily wage
        public void DisplayWage()
        {
            Console.WriteLine("Employee worked for {0} hours and earned {1}", hoursWorked, CalculateWage());
        }

        // Method to set the number of hours worked
        public void SetHoursWorked(int hours)
        {
            hoursWorked = hours;
        }
    }
}
