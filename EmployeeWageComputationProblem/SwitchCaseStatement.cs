using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class SwitchCaseStatement
    {
        // class variable 
        public const int Per_hour = 20;
        public const int Full_Day_Hour = 8;
        public const int Part_Time_Hour = 4;
        public const int Wage_per_Hour = 20;
        Random random = new Random();
        // UC4 Switch Case
        public void SwitchCase()
        {
            int dailyEmpWage = 0;
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Randomly Selected The Full_Day_Hour & Part_Time_Hour ");  
            switch (empCheck)
            {

                case 0:
                    dailyEmpWage = Full_Day_Hour * Per_hour;
                    Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
                    break;
                case 1:
                    dailyEmpWage = Part_Time_Hour * Per_hour;
                    Console.WriteLine("Daily Emp Wage Part Time :" + dailyEmpWage);
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
        }
    }
}

