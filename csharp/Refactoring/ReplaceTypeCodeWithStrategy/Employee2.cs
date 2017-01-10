using System;

namespace Kata.Refactoring.ReplaceTypeCodeWithStrategy
{
    public class Employee2
    {
        public const int
            Engineer = 0,
            Salesman = 1,
            Manager = 2;


        public Employee2(int type)
        {
            TypeCode = type;
        }

        public int TypeCode
        {
            get { return EmployeeType.Code; }
            set { EmployeeType = EmployeeType2.CreateFromCode(value); }
        }

        public EmployeeType2 EmployeeType { get; set; }

        public int PayAmount()
        {
            return EmployeeType.PayAmount();
        }
    }

    public abstract class EmployeeType2
    {
        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public abstract int Code { get; }

        public static EmployeeType2 CreateFromCode(int typeCode)
        {
            switch (typeCode)
            {
                case Employee2.Engineer:
                    return new Engineer();
                case Employee2.Salesman:
                    return new Salesman();
                case Employee2.Manager:
                    return new Manager();
                default:
                    throw new Exception("Incorrect Employee Type");
            }
        }

        public abstract int PayAmount();
    }

    public class Manager : EmployeeType2
    {
        public override int Code => Employee2.Manager;
        public override int PayAmount()
        {
            return MonthlySalary + Bonus;
        }
    }

    public class Salesman : EmployeeType2
    {
        public override int Code => Employee2.Salesman;
        public override int PayAmount()
        {
            return MonthlySalary + Commission;
        }
    }

    public class Engineer : EmployeeType2
    {
        public override int Code => Employee2.Engineer;
        public override int PayAmount()
        {
            return MonthlySalary;
        }
    }
}