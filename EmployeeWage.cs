using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputaion
{
    public class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        
        public static int computeEmpWage(string company,int empRateperHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            //Variables
            int empHours = 0;
            int totalEmpHrs = 0, totalWorkindDays = 0;

            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkindDays < numOfWorkingDays)
            {
                totalWorkindDays++;
                Random random = new Random();
                int empCheck = random.Next(0,3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHrs += empHours;
                Console.WriteLine("Day#: " + totalWorkindDays + " Emp Hrs: " + empHours);
            }
            int totalEmpWage = totalEmpHrs * empRateperHour;
            Console.WriteLine("Total Emp Wage for company: " + company+ " is: " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
