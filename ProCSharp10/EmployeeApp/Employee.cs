using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Employee
    {
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private string _empSSN;
        private EmployeePayTypeEnum _empPayType;
        private DateTime _hireDate;

        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, String.Empty, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int id, float pay, string empSSN)
            : this(name, 0, id, pay, empSSN, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, string empSSN, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            SocialSecurityNumber = empSSN;
            PayType = payType;
        }

        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate.Year: > 2020 } => Pay += 0.10F * amount,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020  } => Pay += 40F * amount / 2080F,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate.Year: > 2020  } => Pay += amount,
                _ => Pay += 0
            };
        }

        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Illegal name too long");
                else
                    _empName = value;
            }
        }
        public int Id { get { return _empId; } set { _empId = value; } }
        public float Pay { get { return _currPay; } set { _currPay = value; } }
        public int Age { get { return _empAge; } set { _empAge = value; } }
        public string SocialSecurityNumber
        {
            get { return _empSSN; }
            private set { _empSSN = value; }
        }
        public EmployeePayTypeEnum PayType
        {
            get { return _empPayType; }
            set { _empPayType = value; }
        }
        public DateTime HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }
    }
}
