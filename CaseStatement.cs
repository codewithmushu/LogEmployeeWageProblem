using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
    class CaseStatement
    {
        // Instance variables
        private string name;
        private int hoursWorked;

        // Constructor
        public CaseStatement(string name)
        {
            this.name = name;
        }

        // Method to set the hours worked
        public void SetHoursWorked(int hours)
        {
            hoursWorked = hours;
        }

        // Method to calculate and print the wage
        public void CalculateWage()
        {
            int wage = hoursWorked * 4;  // Part time wage is assumed to be 4 per hour
            Console.WriteLine("{0} worked for {1} hours and earned ${2}", name, hoursWorked, wage);
        }
    }
}
