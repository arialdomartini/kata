using System;
using System.Text;

namespace Kata.Refactoring.ReplaceTypeCodeWithStrategy
{
    public class Employee
    {
        private EmployeeType _employeeType;

        public int EmployeeCode
        {
            get { return _employeeType.EmployeeCode; }
            set { _employeeType = EmployeeType.Create(value); }
        }

        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public Employee(int typeCode)
        {
            EmployeeCode = typeCode;
        }

        public int PayAmount()
        {
            return _employeeType.PayAmount(this);
        }
    }


    abstract class EmployeeType
    {
        public const int
            Engineer = 0,
            Salesman = 1,
            Manager = 2;

        public static EmployeeType Create(int code)
        {
            switch (code)
            {
                case Engineer:
                    return new Engineer();

                case Salesman:
                    return new Salesman();

                case Manager:
                    return new Manager();

                default:
                    throw new Exception("Incorrect Employee Type");
            }
        }

        public abstract int EmployeeCode { get; }

        public abstract int PayAmount(Employee employee);


    }

    class Salesman : EmployeeType
    {
        public override int EmployeeCode => EmployeeType.Salesman;
        public override int PayAmount(Employee employee)
        {
            return employee.MonthlySalary + employee.Commission;
        }
    }

    class Manager : EmployeeType
    {
        public override int EmployeeCode => EmployeeType.Manager;
        public override int PayAmount(Employee employee)
        {
            return employee.MonthlySalary + employee.Bonus;
        }
    }

    class Engineer : EmployeeType
    {
        public override int EmployeeCode => EmployeeType.Engineer;
        public override int PayAmount(Employee employee)
        {
            return employee.MonthlySalary;
        }
    }
}