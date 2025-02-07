namespace _2_Employee
{
    public partial class Employee
    {
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private string _empSSN;
        private EmployeePayTypeEnum _empPayType;
        private DateTime _hireDate;
        protected BenefitsPackage EmpBenefits = new BenefitsPackage();

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
        public BenefitsPackage Benefits { get { return EmpBenefits; } set { EmpBenefits = value; } }
    }
}