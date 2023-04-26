using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputaion
{
    public class EmployeeWage
    {
        public static void EmpAttendance()
        {
            int IS_FULL_TIME = 1, EMP_RATE_PER_HOUR = 20;
            int empHour = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
