using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmployeeWageMultipleCompanies
    {

        public const int ABSENT = 0;
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;


        public void EmpWages(string company)
        {

            int empHours = 0;
            int empWage = 0;
            int workingHrs = 0;
            int totalWage = 0;
            int Working_Days = 0;
            Random random = new Random();
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
            {
                int empInput = random.Next(0, 4);
                switch (empInput)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default: // Assume As Absent
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee {0} is and monthly salary is : " + totalEmpWage, company);    
        }
    }
}
