using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
    class MultipleCompEmpWage
    {
        public static void ComputeWage(string companyName, int wagePerHour, int fullDayHour, int partTimeHour, int maxWorkingDays, int maxWorkingHours)
        {
            int totalWorkingHours = 0;
            int totalWorkingDays = 0;
            int totalWage = 0;

            while (totalWorkingHours < maxWorkingHours && totalWorkingDays < maxWorkingDays)
            {
                totalWorkingDays++;

                Random random = new Random();
                int employeeCheck = random.Next(0, 3);

                switch (employeeCheck)
                {
                    case 0:
                        // Full Time Employee
                        totalWorkingHours += fullDayHour;
                        break;
                    case 1:
                        // Part Time Employee
                        totalWorkingHours += partTimeHour;
                        break;
                    default:
                        // Employee is Absent
                        break;
                }
            }

            totalWage = totalWorkingHours * wagePerHour;
            Console.WriteLine("Company Name: " + companyName);
            Console.WriteLine("Total Working Days: " + totalWorkingDays);
            Console.WriteLine("Total Working Hours: " + totalWorkingHours);
            Console.WriteLine("Total Wage: " + totalWage);
        }
    }
}
