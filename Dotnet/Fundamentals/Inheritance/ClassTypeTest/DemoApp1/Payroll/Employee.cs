namespace Payroll
{
    class Employee
    {
        private int hours;
        private float rate;

        public Employee(int h,float r)
        {
            hours = h;
            rate = r;
        }

        public Employee() : this (125,50)
        {

        }

        public int Hours{ get; set;}
        public float Rate{get; set;}

        public virtual double Income()
        {
            double amount = hours * rate;
            int ot = hours - 180;
            if(ot >0)
                amount += 50*ot;
            return amount;
        }

    }
}