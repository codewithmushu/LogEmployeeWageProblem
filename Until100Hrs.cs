using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_no__8
{
     class Until100Hrs
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HourlyWage { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }

        public Until100Hrs(string firstName, string lastName, int hourlyWage)
        {
            FirstName = firstName;
            LastName = lastName;
            HourlyWage = hourlyWage;
        }

        public virtual int Work()
        {
            return 0;
        }

        public int CalculateWage(int hoursWorked)
        {
            return HourlyWage * hoursWorked;
        }
     }

    class FullTimeEmployee : Until100Hrs
    {
        public int HoursPerDay { get; set; }

        public FullTimeEmployee(string firstName, string lastName, int hoursPerDay) : base(firstName, lastName, 20)
        {
            HoursPerDay = hoursPerDay;
        }

        public override int Work()
        {
            return HoursPerDay;
        }
    }

    class PartTimeEmployee : Until100Hrs
    {
        public PartTimeEmployee(string firstName, string lastName, int v) : base(firstName, lastName, 20)
        {
        }

        public override int Work()
        {
            return 4;
        }
    }


}
