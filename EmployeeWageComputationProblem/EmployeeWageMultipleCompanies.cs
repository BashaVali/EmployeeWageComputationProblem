using System;

namespace EmployeeWages
{
    class EmployeeWageMultipleCompany
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //public const int IS_FULL_TIME = 2;
        //public const int EMP_RATE_PER_HOUR = 20;
        //public const int NUMBER_OF_WORKING_DAYS = 20;
        //public const int MAX_HOURS_IN_MONTH = 100;

        public void ComputeWage(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
        {
            int empHours = 0;
            int empDailyWage = 0;
            int workingDays = 1;
            int workingHrs = 0;
            int totalWage = 0;
            //Creating a Random Function
            Random random = new Random();

            while (workingDays <= max_working_days && workingHrs <= maxHoursPerMonth)
            {
                //Calling the next method in Random Class
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                        // Console.WriteLine("Employee is present for full-time");
                        empHours = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("Employee is present for part-time");
                        empHours = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee is absent");
                        break;

                }
                empDailyWage = empHours * wage_per_hour;
                totalWage += empDailyWage;
                workingHrs += empHours;
                if (empInput != 0)
                {
                    workingDays++;

                }
                Console.WriteLine("Company Name:" + company);
                Console.WriteLine("Working Hours :" + workingHrs);
                Console.WriteLine("Employee Wage Per day :" + empDailyWage);
                Console.WriteLine("Working days in a month :" + workingDays);
                Console.WriteLine("Employee Wage for Total working days :" + totalWage);
            }

        }
    }
}