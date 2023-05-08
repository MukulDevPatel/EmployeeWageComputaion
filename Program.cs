using System;

namespace EmployeeWageComputaion
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computaion program");

            EmployeeWage.computeEmpWage("DMart",20,2,10);
            EmployeeWage.computeEmpWage("Reliance", 20, 4, 10);
        }
    }
}
