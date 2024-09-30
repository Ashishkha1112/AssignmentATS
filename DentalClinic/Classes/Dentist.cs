namespace ClinicManagement;
public class Dentist : Persons , IMedicine
{ 
    private int id;
    private string spaciality;
    public  Dentist(int i,string n, string a, string e, double p, string g, DateTime d, string sp):base(n,a,e,p,g,d)
    {
        id = i;
        spaciality=sp;
    }
    public override void PrintDetails()
    {
        Console.WriteLine($" Dentist ID :  {id}\n");
        base.PrintDetails();
         Console.WriteLine($" Spaciality  :  {spaciality}\n");
         

    }
      public void PrescribeMedicine(){
        Console.WriteLine("Dentist Prescribe for Medicine.");
      }
}