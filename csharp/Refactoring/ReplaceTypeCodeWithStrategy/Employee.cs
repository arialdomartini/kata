using System;

namespace Kata.Refactoring.ReplaceTypeCodeWithStrategy
{
    public class Employee
    {
        public const int
            Engineer = 0,
            Salesman = 1,
            Manager = 2;

        public int Type;
        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public Employee(int type)
        {
            Type = type;
        }

        public int PayAmount()
        {
            switch (Type)
            {
                case Engineer:
                    return MonthlySalary;
                case Salesman:
                    return MonthlySalary + Commission;
                case Manager:
                    return MonthlySalary + Bonus;
                default:
                    throw new Exception("Incorrect Employee Type");
            }
        }
    }
}