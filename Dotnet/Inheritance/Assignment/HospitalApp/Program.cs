using Hospital;

class Program
{
    static void Main(string[] args)
    {
        Patient p = new Patient(1,2,5);
        InhousePatient n = new InhousePatient(1,2,5,0.10);

        System.Console.WriteLine("Patient's bill = {0:000}",p.GetBill());
        System.Console.WriteLine("Inhouse Patient's bill = {0:000}",n.GetBill());
    }
}