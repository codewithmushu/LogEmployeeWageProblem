using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
    class MonthlyWage
    {
        // Instance variables
        private string name;
        private int hoursWorked;

        // Constructor
        public MonthlyWage(string name)
        {
            this.name = name;
        }

        // Method to set the hours worked
        public void SetHoursWorked(int hours)
        {
            hoursWorked = hours;
        }

        // Method to calculate and print the wage for a month
        public void CalculateMonthlyWage()
        {
            int hourlyWage = 20;
            int wage;

            if (hoursWorked == 8)
            {
                wage = hourlyWage * hoursWorked * 20; // Full-time employee, works 8 hours a day, 20 working days a month
                Console.WriteLine("{0} is a full-time employee who worked for {1} hours and earned Rs {2} for the month", name, hoursWorked * 20, wage);
            }
            else if (hoursWorked == 4)
            {
                wage = hourlyWage * hoursWorked * 20; // Part-time employee, works 4 hours a day, 20 working days a month
                Console.WriteLine("{0} is a part-time employee who worked for {1} hours and earned Rs {2} for the month", name, hoursWorked * 20, wage);
            }
            else
            {
                Console.WriteLine("{0} has invalid working hours.", name);
            }
        }
    }
}
