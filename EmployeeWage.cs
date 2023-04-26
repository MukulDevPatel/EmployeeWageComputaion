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
            int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20;
            int empHour = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
            Console.WriteLine("Random value: " + empCheck);
            switch (empCheck)
            {
                case 1:
                    empHour = 8; 
                    break;
                case 2:
                    empHour = 4;
                    break;
                case 3:
                    empHour = 0;
                    break;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
