namespace PeopleManagement;
public class Person
{
    public int index;
    public string userId;
    public string firstName;
    public string lastName;
    public string sex;
    public string email;
    public string phone;
    public DateTime dateOfBirth;
    public string jobTitle;

    public Person(
        int i,
        string id,
        string fName,
        string lName,
        string s,
        string e,
        string p,
        DateTime d,
        string j
    )
    {
        index = i;
        userId = id;
        firstName = fName;
        lastName = lName;
        sex = s;
        email = e;
        phone = p;
        dateOfBirth = d;
        jobTitle = j;
    }
}
