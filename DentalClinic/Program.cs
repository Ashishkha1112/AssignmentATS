using System;

namespace ClinicManagement
{
    class Program
    {
        static void Main(string[] args) // Use static Main method
        {
            var dentist = new Dentist(
                1,
                "Ram",
                "KTM",
                "xyz@test.com",
                986815557,
                "Male",
                new DateTime(1990, 05, 10),
                "Orthologist"
            );
            dentist.PrintDetails(); 
            dentist.PrescribeMedicine();

            var patient = new Patient(
                1, 
                "Bat Man", 
                "KTM", 
                "bat@test.com", 
                986855556, 
                "Male", 
                new DateTime(1995, 03, 15), 
                "Toothache", 
                "No known allergies"
            );
            patient.PrintDetails(); 
            patient.PrescribeMedicine();

            var criticalPatient = new CriticalPatient(
                1,
                "shyam",
                "KTM",
                "shyam@gmail.com",
                986855558,
                "Female",
                new DateTime(1990, 07, 20),
                "Severe tooth pain",
                "Diabetes",
                "High blood pressure"
            );
            criticalPatient.PrintDetails(); 
            criticalPatient.PrescribeMedicine();

            var admin = new Admin(
                1,
                "Rakesh",
                "KTM",
                "rakesh@example.com",
                986855559,
                "Female",
                new DateTime(1988, 11, 5),
                "Office Manager"
            );
            admin.PrintDetails(); 
        }
    }
}
