using System.Data.Common;
namespace ClinicManagement;
public class Admin : Persons
{
    private  string role;
    private int id;


     public Admin( int i, string n, string a, string e, double p, string g, DateTime d,string r):base(n,a,e,p,g,d)
    {
        id=i;
      role =r; 

    }
    public override void PrintDetails()
    {
        Console.WriteLine($" Admin Id:{id}\n");
        base.PrintDetails();
         Console.WriteLine($" Role: {role}");
    }

} 