﻿using System;
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
            int IS_FULL_TIME = 1;
            int EMP_WAGE_PER_HR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random= new Random();
            int empcheck = random.Next(0, 2);
            if(empcheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else 
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_WAGE_PER_HR;
            Console.WriteLine("Employee Wage is :" +empwage);
        }
    }
}
