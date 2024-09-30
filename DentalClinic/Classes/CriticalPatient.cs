namespace ClinicManagement;
public class CriticalPatient : Patient
{
    private  string criticalCondition;
     public CriticalPatient( int id, string n, string a, string e, double p, string g, DateTime d, string sy, string mh , string cd):base(id,n,a,e,p,g,d,sy,mh)
    {
      criticalCondition=cd;

    }
    public override void PrintDetails()
    {

        base.PrintDetails();
    Console.WriteLine($"Critical Condition:{criticalCondition}");
    }
}