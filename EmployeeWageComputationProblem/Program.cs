using EmployeeWages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the EmployeeWageComputationProblem");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("****** Employee Wage Problem ******");

                Console.WriteLine(" Select the option ");

                Console.WriteLine("1.Attendance" + "\n" +
                                  "2.DailyEmployeeWage" + "\n" +
                                  "3.PartTimeEmployeeWage" + "\n" +
                                  "4.SwitchCaseStatement" + "\n " +
                                  "5.MonthWages" + "\n" +
                                  "6.TotalMonthlyWorkingHours" + "\n" +
                                  "7.RefactorEmployeeWageClass" + "\n "+
                                  "8.EmployeeWageMultipleCompanies"+ "\n " +
                                  "9.Exit" + "\n");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        EmployeeWageProblem employeeWageProblem = new EmployeeWageProblem();
                        employeeWageProblem.EmployeeAttendence();
                        break;
                    case 2:
                        EmployeeWageProblem1 employeeWageProblem1= new EmployeeWageProblem1();
                        employeeWageProblem1.DailyEmployeeWage();
                        break;
                    case 3:
                        PartTimeEmployeeWage partTimeEmployeeWage = new PartTimeEmployeeWage();
                        partTimeEmployeeWage.PartTimeEmpWage();
                        break;
                    case 4:
                        SwitchCaseStatement switchCaseStatement = new SwitchCaseStatement();
                        switchCaseStatement.SwitchCase();
                        break;
                    case 5: 
                        MonthWages monthWages = new MonthWages();
                        monthWages.MonthlyEmployeeWage();
                        break;
                    case 6:
                        TotalMonthlyWorkingHours totalMonthlyWorkingHours = new TotalMonthlyWorkingHours();
                        totalMonthlyWorkingHours.TotalMonthlyWages();
                        break;
                    case 7:
                        RefactorEmployeeWageClassMethod refactorEmployeeWageClassMethod = new RefactorEmployeeWageClassMethod();
                        refactorEmployeeWageClassMethod.RefactorEmployeeWageClass();
                        break;
                        case 8:
                        Console.WriteLine("Welcome to employee wage computation");
                        EmployeeWageMultipleCompany employeeWageMultipleCompany = new EmployeeWageMultipleCompany();
                        employeeWageMultipleCompany.ComputeWage("Accenture", 60, 50, 90);
                        EmployeeWageMultipleCompany employeeWageMultipleCompany1 = new EmployeeWageMultipleCompany();
                        employeeWageMultipleCompany1.ComputeWage("TCS", 65, 55, 95);
                        EmployeeWageMultipleCompany employeeWageMultipleCompany2 = new EmployeeWageMultipleCompany();
                        employeeWageMultipleCompany2.ComputeWage("CapGemini", 70, 75, 100);
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}














    













    
