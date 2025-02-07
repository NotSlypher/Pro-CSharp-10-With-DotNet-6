using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Employee
{
    public abstract partial class Employee
    {

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

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public virtual void DisplayStats()
        {
            Console.WriteLine($"name is{Name}, Id is {Id}, Age is {Age}, Pay is {Pay}, SSN is {SocialSecurityNumber}");
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
            }
            else if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options", emp.Name, ((Manager)emp).StockOptions);
            }
            Console.WriteLine();
        }
    }
}
