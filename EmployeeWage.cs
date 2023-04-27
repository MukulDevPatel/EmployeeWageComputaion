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
        public const int EMP_RATE_PER_HOUR = 20;
        public const int TOTAL_WORKING_DAYS = 20;
        public const int TOTAL_WORKING_HRS = 100;
        public static void EmpAttendance()
        {
            int empHours = 0;
            int totalEmpHrs = 0, totalWorkindDays = 0;
            
            while (totalEmpHrs <= TOTAL_WORKING_HRS && totalWorkindDays<TOTAL_WORKING_DAYS)
            {
                totalWorkindDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                
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
                totalEmpHrs = totalEmpHrs + empHours;

                Console.WriteLine("Day#: " + totalWorkindDays + " Emp Hrs: " + empHours);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}
