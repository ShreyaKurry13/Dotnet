namespace Hospital
{
    class InhousePatient : Patient
    {
        private double discount = 0.10;
        public double Discount{get; set;}

        public InhousePatient(int pid, int btype,int d,double dis) : base(pid, btype,d)
        {
            discount = dis;
        }

        public override double GetBill()
        {
            double discountamt = base.GetBill() - base.GetBill() * discount;
            return discountamt;
        }

    }
}