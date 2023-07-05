﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmployeeDailyWage
    {
        // Emp wage solved using Switch case
        public const int EMP_RAT_PER_HOUR = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static void CalculateEmployeeDailyWage()
        {
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
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
            empWage = empHour * EMP_RAT_PER_HOUR;
            Console.WriteLine("Employee Wage :" + empWage);
        }
    }
}
