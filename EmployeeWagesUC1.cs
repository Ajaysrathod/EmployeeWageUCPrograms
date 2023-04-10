using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageUCPrograms
{
    public class EmployeeWagesUC1
    {
        //Created method to check Employee is present or absent
        public static void EmployeeUC1(int empCheck)
        {
            int IS_PRESENT = 1;
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}

