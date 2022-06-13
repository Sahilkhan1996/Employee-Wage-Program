using System;

namespace Emp_Wage
{
    internal class EmpWageAssigment
    {
        static int fullday = 8;
        static int wageperhour = 20;
        static void Main(string[] args)
        {

            //Calculating daily wage of the Employee
            
            Random check = new Random();
            int presentorabsent = check.Next(0, 2);
            Console.WriteLine(presentorabsent);
            if (presentorabsent == 1)
            {
                Console.WriteLine("Emp is present");
                int dailywage = fullday * wageperhour;
                Console.WriteLine("Daily wage of the Emp is " + dailywage);
            }
            else
            {
                Console.WriteLine("Emp is absent");
            }

        }
    }
}
