using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class TotalMonthlyWorkingHours
    {
        // class variable 
       
        public const int Full_Day_Hour = 8;
        public const int Part_Time_Hour = 4;
        public const int Wage_per_Hour = 20;    
        //UC6-TotalMonthlyWages
        public void TotalMonthlyWages()
        {
            int day = 0, hours = 0, DailyEmpWage = 0, EmpWage = 0;
            while (day < 20 & hours < 100)
            {
                day++;
                hours += 8;

            }
            EmpWage = day * hours;
            DailyEmpWage = Wage_per_Hour * EmpWage;
            Console.WriteLine("Employee TotalMonthlyWorkingHours Wage :" + DailyEmpWage);

        }
    }
}