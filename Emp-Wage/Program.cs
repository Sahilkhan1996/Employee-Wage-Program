using System;

namespace Emp_Wage
{
    internal class EmpWageAssigment
    {
        static int fullday = 8;
        static int wageperhour = 20;
        static int parttimehour = 4;

        static void Main(string[] args)
        {            
            Random check = new Random();
            int presentorabsent = check.Next(0, 2);
            Console.WriteLine(presentorabsent);
            if (presentorabsent == 1)
            {
                //Calculating daily wage of the Employee
                Console.WriteLine("Emp is present");
                int dailywage = fullday * wageperhour;
                Console.WriteLine("Daily wage of the Emp is " + dailywage);
                //Part time Emp wage Emp and wage
                int parttimewage = parttimehour * wageperhour;
                Console.WriteLine("Part time wage of the Emp is " + parttimewage);

            }
            else
            {
                Console.WriteLine("Emp is absent");
            }

        }
    }
}
