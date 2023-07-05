using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmployeeDailyWage
    {

        const int EMP_RATE_PER_HOUR = 20;        
        static int totalWorkingDays = 0;
        static int totalWorkingHours = 0;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;        
        public static void CalculateEmployeeDailyWage()
        {
            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            Random rdm = new Random();
            while (totalWorkingDays < NUM_OF_WORKING_DAYS && totalWorkingHours < MAX_HRS_IN_MONTH)
            {
                totalWorkingDays++;
                int empCheck = rdm.Next(3);
                switch (empCheck)
                {
                    case 1:
                        empHour = 8;
                        break;
                    case 2:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                if (MAX_HRS_IN_MONTH > totalEmpHour)
                {
                    totalEmpHour += empHour;
                    empWage = empHour * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                }
            }
            Console.WriteLine("Total Working Days: " + totalWorkingDays);
            Console.WriteLine("Total Working Hours: " + totalEmpHour);
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}
