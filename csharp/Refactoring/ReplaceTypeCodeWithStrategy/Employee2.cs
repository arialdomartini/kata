using System;
using System.Collections.Generic;
using System.Linq;

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
        private static List<EmployeeType2> _employeeTypes;
        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public abstract int Code { get; }

        protected EmployeeType2()
        {
            _employeeTypes = new List<EmployeeType2>
            {
                new Manager2(),
                new Engineer2(),
                new Salesman2()
            };
        }

        public static EmployeeType2 CreateFromCode(int typeCode)
        {
            var employeeType = _employeeTypes.FirstOrDefault(e => e.Code == typeCode);
            if(employeeType == null)
                    throw new Exception("Incorrect Employee Type");
            return employeeType;
        }

        public abstract int PayAmount();
    }

    public class Manager2 : EmployeeType2
    {
        public override int Code => Employee2.Manager;
        public override int PayAmount()
        {
            return MonthlySalary + Bonus;
        }
    }

    public class Salesman2 : EmployeeType2
    {
        public override int Code => Employee2.Salesman;
        public override int PayAmount()
        {
            return MonthlySalary + Commission;
        }
    }

    public class Engineer2 : EmployeeType2
    {
        public override int Code => Employee2.Engineer;
        public override int PayAmount()
        {
            return MonthlySalary;
        }
    }
}