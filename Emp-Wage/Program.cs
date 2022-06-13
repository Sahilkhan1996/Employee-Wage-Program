using System;

namespace Emp_Wage
{
    internal class EmpWageAssigment
    {
        static void Main(string[] args)
        {
            //Checking emp is present of absent

            Random check = new Random();
            int presentorabsent = check.Next(0, 2);
            Console.WriteLine(presentorabsent);
            if (presentorabsent == 1)
            {
                Console.WriteLine("Emp is present");
            }
            else
            {
                Console.WriteLine("Emp is absent");
            }

        }
    }
}
