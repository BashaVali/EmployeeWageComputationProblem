using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class MonthWages
    {
        // class variable 
        public const int Per_hour = 20;
        public const int Full_Day_Hour = 8;
        public const int Part_Time_Hour = 4;
        public const int Wage_per_Hour = 20;
        public const int Working_Day = 20;
        Random random = new Random();

        //UC-5
        //Assume  20 working Days per Month
        //Assume Full day hour is 8
        public void MonthlyEmployeeWage()
        {
            int monthlyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == empHrs)
                empHrs = Per_hour * Full_Day_Hour;
            else
            empCheck = random.Next(0, 2);
            monthlyEmpWage = Working_Day * empHrs;
            Console.WriteLine("Daily Emp Wage for a Month :" + monthlyEmpWage);
        }
    }
}
    

