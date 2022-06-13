using System;

namespace Emp_Wage
{
    internal class EmpWageAssigment
    {
        static int fullday = 8;
        static int wageperhour = 20;
        static int parttimehour = 4;
        static int NumberOfWorkingDays=20;
        static int totalemppwage;
        static void Main(string[] args)
        {

            for (int i = 0; i < NumberOfWorkingDays; i++)
            {
                Random check1 = new Random();
                int presentorabsent1 = check1.Next(0, 3);
                Console.WriteLine(presentorabsent1);

                switch (presentorabsent1)
                {
                    case 1:
                        totalemppwage = totalemppwage + parttimehour * wageperhour;
                        break;
                    case 2:
                        totalemppwage = totalemppwage + fullday * wageperhour;
                        break;
                    case 3: Console.WriteLine("Employee is absent"); break;

                }
            }
            Console.WriteLine("total Emp wage is: " +totalemppwage);
        }
    }
}
