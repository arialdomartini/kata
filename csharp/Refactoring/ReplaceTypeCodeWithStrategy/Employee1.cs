using System;
using System.Text;

namespace Kata.Refactoring.ReplaceTypeCodeWithStrategy
{
    public class Employee1
    {
        private EmployeeType1 _employeeType;

        public int EmployeeCode
        {
            get { return _employeeType.EmployeeCode; }
            set { _employeeType = EmployeeType1.Create(value); }
        }

        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public Employee1(int typeCode)
        {
            EmployeeCode = typeCode;
        }

        public int PayAmount()
        {
            return _employeeType.PayAmount(this);
        }
    }


    abstract class EmployeeType1
    {
        public const int
            Engineer = 0,
            Salesman = 1,
            Manager = 2;

        public static EmployeeType1 Create(int code)
        {
            switch (code)
            {
                case Engineer:
                    return new Engineer1();

                case Salesman:
                    return new Salesman1();

                case Manager:
                    return new Manager1();

                default:
                    throw new Exception("Incorrect Employee1 Type");
            }
        }

        public abstract int EmployeeCode { get; }

        public abstract int PayAmount(Employee1 employee1);


    }

    class Salesman1 : EmployeeType1
    {
        public override int EmployeeCode => EmployeeType1.Salesman;
        public override int PayAmount(Employee1 employee1)
        {
            return employee1.MonthlySalary + employee1.Commission;
        }
    }

    class Manager1 : EmployeeType1
    {
        public override int EmployeeCode => EmployeeType1.Manager;
        public override int PayAmount(Employee1 employee1)
        {
            return employee1.MonthlySalary + employee1.Bonus;
        }
    }

    class Engineer1 : EmployeeType1
    {
        public override int EmployeeCode => EmployeeType1.Engineer;
        public override int PayAmount(Employee1 employee1)
        {
            return employee1.MonthlySalary;
        }
    }
}