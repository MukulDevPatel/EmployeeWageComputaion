using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputaion
{
    public class EmpWageBuilder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            //Variables
            int empHours = 0;
            int totalEmpHrs = 0, totalWorkindDays = 0;

            //Computation
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkindDays < this.numOfWorkingDays)
            {
                totalWorkindDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

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
            int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is: " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
