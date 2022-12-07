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
                        EmployeeWageMultipleCompanies employeeWageMultipleCompanies = new EmployeeWageMultipleCompanies();
                        employeeWageMultipleCompanies.EmpWages("Accenture");
                        EmployeeWageMultipleCompanies employeeWageMultipleCompanies1 = new EmployeeWageMultipleCompanies();
                        employeeWageMultipleCompanies1.EmpWages("TCS");
                        EmployeeWageMultipleCompanies employeeWageMultipleCompanies2 = new EmployeeWageMultipleCompanies();
                        employeeWageMultipleCompanies2.EmpWages("CapGemini");
                        EmployeeWageMultipleCompanies employeeWageMultipleCompanies3= new EmployeeWageMultipleCompanies();
                        employeeWageMultipleCompanies3.EmpWages("Wipro");
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}














    













    
