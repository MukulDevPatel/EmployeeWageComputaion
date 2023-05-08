using System;

namespace EmployeeWageComputaion
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computaion program");

            EmpWageBuilder dMart=new EmpWageBuilder("DMart", 20, 2, 10);
            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 20, 4, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
