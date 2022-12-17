using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProgram
{
    public class EmployeeAttendance
    {
        public static void CheckAttendance()
        {
           const int IS_FULL_TIME = 1;
           const int IS_PART_TIME = 2;
            int EMP_WAGE_PER_HR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random= new Random();
            int empcheck = random.Next(0, 3);
            switch(empcheck)
            {
                case IS_FULL_TIME:
                Console.WriteLine("Employee is Full Time Present");
                emphrs = 8;
                    break;
                case IS_PART_TIME:
                Console.WriteLine("Employee is Part Time Present");
                emphrs = 4;
                    break;
                default:
                Console.WriteLine("Employee is Absent");
                emphrs = 0;
                    break;
            }
            empwage = emphrs * EMP_WAGE_PER_HR;
            Console.WriteLine("Employee Wage is :" +empwage);
        }
    }
}
