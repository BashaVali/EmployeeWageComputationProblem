using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class RefactorEmployeeWageClassMethod
    {
        public const int ABSENT = 0;
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS =20;
        public const int MAX_HOURS_IN_MONTH = 100;

     public  void   RefactorEmployeeWageClass()
        {   
            //Variables
            int empHrs = 0,totalEmpHrs =0, totalWorkingDays =0;
            // Computation
            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
           
            {
                totalWorkingDays++;
                Console.WriteLine("Select the option");
                Console.WriteLine("1.Part Time" + "\n" +
                                  "2.Full Time" + "\n" +
                                  "3.Absent" + "\n");
                                  
               int options = Convert.ToInt32(Console.ReadLine());                       
               switch (options)
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
                Console.WriteLine("Day#" + totalWorkingDays + " Emp Hrs  :" + empHrs);
            }
            int totalEmpWage= totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);                     
            
        }
    }
}
