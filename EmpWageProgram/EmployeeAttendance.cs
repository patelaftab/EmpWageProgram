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
            int NUM_OF_WORKING_DAYS = 20;
            int MAX_WORKING_HRS = 100;
            int emphrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHRS = 0;
            while (totalEmpHRS  <= MAX_WORKING_HRS && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
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
                totalEmpHRS += totalEmpHRS;
                Console.WriteLine("Employee Working Days :" + totalWorkingDays + "Employee Working HRS :" +emphrs);
            }
            int totalEmpWage = totalEmpHRS + EMP_WAGE_PER_HR;
            Console.WriteLine("Total Wage Of Employee is :" +totalEmpWage );
        }
    }
}
