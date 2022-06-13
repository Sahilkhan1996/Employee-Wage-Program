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
            int dailywage = fullday * wageperhour;
            int fulltimeempwage = dailywage * 30;
            int parttimewage = parttimehour * wageperhour;
            Console.WriteLine(fulltimeempwage);
            Random check1 = new Random();
            int presentorabsent1 = check1.Next(0, 2);
            Console.WriteLine(presentorabsent1);

            switch (presentorabsent1)
            {
                case 1: Console.WriteLine("1Part time Emp wage: " + parttimewage); break;
                case 2: Console.WriteLine("2Full time Empwage: " + fulltimeempwage); break;
            }


        }
    }
}
