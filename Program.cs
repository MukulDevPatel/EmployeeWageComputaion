using System;

namespace EmployeeWageComputaion
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computaion program");

            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("DMart", 20, 20, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 20, 19, 10);
            empWageBuilderArray.computeEmpWage();
        }
    }
}
