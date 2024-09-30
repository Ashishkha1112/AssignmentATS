namespace ClinicManagement;
public class Patient : Persons, IMedicine
{
    private string symptoms;
    private string medicalHistry;
    private int pId;

    public Patient(int id,string n, string a, string e, double p, string g, DateTime d, string sy, string mh)
        : base(n, a, e, p, g, d)
    {
        pId=id;
        medicalHistry = mh;
        symptoms = sy;
    }

    public override void PrintDetails()
    {Console.WriteLine($"Patient ID :  {pId}\n");
        base.PrintDetails();
         Console.WriteLine($" Symptom  :  {symptoms}\n");
         Console.WriteLine($" Medical History :  {medicalHistry}\n");
    }
     public void PrescribeMedicine(){
        Console.WriteLine("Patient request for Medicine.");
      }
   
    
}
