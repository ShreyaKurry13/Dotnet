namespace Hospital
{
    class Patient
    {
        public int Patientid{get; set;}
        public int BedType{get; set;}
        public int Days{get; set;}
        

        public Patient(int pid, int btype,int d)
        {
            Patientid = pid;
            BedType = btype;
            Days = d;
        }

        public Patient() : this(1,1, 4)
        {}

        public double GetPricePerDay()
        {
            double Price;
            switch(BedType)
            {
                case 1:
                    return Price = 500;
                case 2:
                    return Price = 350;
                case 3:
                    return Price = 200;
                default:
                    return Price = 250;
            }
            return Price;
        }

        public virtual double GetBill()
        {
            double amount = Days * GetPricePerDay();
            return amount;
        }

    }
}