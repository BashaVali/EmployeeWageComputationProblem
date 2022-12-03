using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class PartTimeEmployeeWage
    {
            // class variable 
            public const int Per_hour = 20;
            public const int Full_Day_Hour = 8;
            public const int Part_Time_Hour = 4;
            public const int Wage_per_Hour = 20;
            Random random = new Random();

        //UC-3
        //Assume Wage per Hour is 20
        //Assume ParTime  Hour is 4

         public void PartTimeEmpWage()
         {
                int dailyEmpWage = 0, empHrs = 0;
                int empCheck = random.Next(0, 2);
                if (empCheck == Part_Time_Hour)
                    empHrs = Per_hour;
                else
                    empHrs = 0;
                dailyEmpWage = Part_Time_Hour * Per_hour;
                Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
         } 
    }
}


