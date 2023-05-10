using System;

namespace EmployeeWageComputaion
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computaion program");

            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("DMart", 200, 19, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 200, 12, 10);
            empWageBuilderArray.computeEmpWage();
            Console.WriteLine("\nTotal Emp Wage for DMart company: {0}", empWageBuilderArray.getTotalWage("DMart"));
            Console.WriteLine("Total Emp Wage for Reliance company: {0}", empWageBuilderArray.getTotalWage("Reliance"));
        }
    }
}
