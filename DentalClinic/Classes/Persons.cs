namespace ClinicManagement;
 public class Persons
{
    private String name;
    private String address;
    private String email;
    private double phone;
    private String gender;
    private DateTime dateOfBirth;


    //Parameterized constructor
    public Persons(String n, String a, String e, double p, String g, DateTime d)
    {
        name = n;
        address = a;
        email = e;
        phone = p;
        gender = g;
        dateOfBirth = d;
        
    }

  

    public virtual void PrintDetails()
    {
        var message = $"Name :{name}\n Email:{email}\n Phone: {phone}\n Date of Birth :{dateOfBirth}\n Address: {address}\n Gender: {gender}";
        Console.WriteLine(message);
    }
}
