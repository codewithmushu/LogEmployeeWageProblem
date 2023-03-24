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

            // Create an instance of the Employee class
            Employee emp = new Employee();

            // Display attendance status
            emp.DisplayAttendance();

            // Wait for user input before closing the console window
            Console.ReadKey();

        }
    }
}
