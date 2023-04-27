using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputaion
{
    public class EmployeeWage
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20, WORKING_DAYS = 20;
        public static void EmpAttendance()
        {
            int empHour = 0, empWage = 0, totalEmpWage = 0;
            
            for (int days=0;  days<WORKING_DAYS; days++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                Console.WriteLine("Random value: " + empCheck);
                
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                empWage = empHour * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage: " + empWage);
            }
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}
