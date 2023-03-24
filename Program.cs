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



            // Create an instance of the Employee class for full-time employee
            PartTimeEmpWage empFullTime = new PartTimeEmpWage();
            empFullTime.SetHoursWorked(8);
            empFullTime.DisplayWage();

            // Create an instance of the Employee class for part-time employee
            PartTimeEmpWage empPartTime = new PartTimeEmpWage();
            empPartTime.SetHoursWorked(4);
            empPartTime.SetIsPartTime(true);
            empPartTime.DisplayWage();

            // Wait for user input before closing the console window
            Console.ReadKey();




        }
    }
}
