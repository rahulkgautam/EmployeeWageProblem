using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeAttendance
    {
        public static  void CheckEmployeeAttendance()
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
