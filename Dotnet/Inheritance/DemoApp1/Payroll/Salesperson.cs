namespace Payroll
{   
    class Salesperson : Employee
    {
        private double sales;

        public double Sales{get; set;}

        public Salesperson(int h,float r,double s) : base(h, r)
        {
            sales = s;
        }
        public override double Income()
        {
            double amount = base.Income();
            if(sales >=20000)
                amount += 0.05 * sales;
            return amount;
        }
    }
}



