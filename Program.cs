using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the log employee wage problem");

            //// Create an instance of the Employee class
            //Employee emp = new Employee();

            //// Display attendance status
            //emp.DisplayAttendance();

            //// Wait for user input before closing the console window
            //Console.ReadKey();



            //// Create an instance of the Employee class
            //DailyWage emp = new DailyWage();

            //// Set the number of hours worked
            //emp.SetHoursWorked(8);

            //// Display the daily wage
            //emp.DisplayWage();

            //// Wait for user input before closing the console window
            //Console.ReadKey();



            //// Create an instance of the Employee class for full-time employee
            //PartTimeEmpWage empFullTime = new PartTimeEmpWage();
            //empFullTime.SetHoursWorked(8);
            //empFullTime.DisplayWage();

            //// Create an instance of the Employee class for part-time employee
            //PartTimeEmpWage empPartTime = new PartTimeEmpWage();
            //empPartTime.SetHoursWorked(4);
            //empPartTime.SetIsPartTime(true);
            //empPartTime.DisplayWage();

            //// Wait for user input before closing the console window
            //Console.ReadKey();



            //Console.WriteLine("Enter employee name:");
            //string name = Console.ReadLine();

            //CaseStatement emp = new CaseStatement(name);

            //Console.WriteLine("Is the employee full-time or part-time? (F/P)");
            //char type = char.Parse(Console.ReadLine());

            //switch (type)
            //{
            //    case 'F':
            //    case 'f':
            //        Console.WriteLine("Sorry, full-time employees are not supported in this program.");
            //        break;
            //    case 'P':
            //    case 'p':
            //        Console.WriteLine("Enter the number of hours worked:");
            //        int hours = int.Parse(Console.ReadLine());
            //        emp.SetHoursWorked(hours);
            //        emp.CalculateWage();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid employee type.");
            //        break;
            //}

            //// Wait for user input before closing the console window
            //Console.ReadKey();



            //Console.WriteLine("Enter full-time employee name:");
            //string ftName = Console.ReadLine();
            //MonthlyWage ftEmp = new MonthlyWage(ftName);

            //Console.WriteLine("Enter part-time employee name:");
            //string ptName = Console.ReadLine();
            //MonthlyWage ptEmp = new MonthlyWage(ptName);

            //Console.WriteLine("Enter the number of hours worked by {0}:", ftName);
            //int ftHours = int.Parse(Console.ReadLine());
            //ftEmp.SetHoursWorked(ftHours);
            //ftEmp.CalculateMonthlyWage();

            //Console.WriteLine("Enter the number of hours worked by {0}:", ptName);
            //int ptHours = int.Parse(Console.ReadLine());
            //ptEmp.SetHoursWorked(ptHours);
            //ptEmp.CalculateMonthlyWage();

            //// Wait for user input before closing the console window
            //Console.ReadKey();




            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("John", "Doe", 8);
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Jane", "Doe", 4);

            //int totalWorkingHours = 0;
            //int totalWorkingDays = 0;
            //int maxWorkingHours = 100;
            //int maxWorkingDays = 20;

            //while (totalWorkingHours < maxWorkingHours && totalWorkingDays < maxWorkingDays)
            //{
            //    int hoursWorkedToday = fullTimeEmployee.Work();
            //    totalWorkingHours += hoursWorkedToday;
            //    totalWorkingDays++;

            //    Console.WriteLine("{0} worked {1} hours today.", fullTimeEmployee.FullName, hoursWorkedToday);

            //    if (totalWorkingHours >= maxWorkingHours || totalWorkingDays >= maxWorkingDays)
            //    {
            //        break;
            //    }

            //    hoursWorkedToday = partTimeEmployee.Work();
            //    totalWorkingHours += hoursWorkedToday;

            //    Console.WriteLine("{0} worked {1} hours today.", partTimeEmployee.FullName, hoursWorkedToday);
            //}

            //int fullTimeWage = fullTimeEmployee.CalculateWage(totalWorkingHours);
            //int partTimeWage = partTimeEmployee.CalculateWage(totalWorkingHours);

            //int totalWage = fullTimeWage + partTimeWage;

            //Console.WriteLine("{0} earned {1} rupees this month.", fullTimeEmployee.FullName, fullTimeWage);
            //Console.WriteLine("{0} earned {1} rupees this month.", partTimeEmployee.FullName, partTimeWage);
            //Console.WriteLine("Total wages for the month: {0} rupees.", totalWage);





            Refactoringcode.ComputeWage();

        }
    }
}
