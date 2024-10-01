namespace PeopleManagement;

using System.IO;

public class PeopleReport
{
    string filePath = "";
    FileInfo FInfo => new(filePath);

    public PeopleReport(string path)
    {
        filePath = path;
    }

    public void SaveMales(List<Person> people)
    {
        var maleCsv = Path.Combine(FInfo.DirectoryName, "males.csv");

        try
        {
            var males = people.Where(p => p.sex == "Male").ToList();
            var csvHeader = "Index,UserId,FirstName,LastName,Sex,Email,Phone,DateOfBirth,JobTitle";

            var csvContent = string.Join(
                Environment.NewLine,
                males.Select(p =>
                    $"{p.index},{p.userId},{p.firstName},{p.lastName},{p.sex},{p.email},{p.phone},{p.dateOfBirth},{p.jobTitle}"
                )
            );

            // Write header and content to the CSV file
            File.WriteAllText(maleCsv, csvHeader + Environment.NewLine + csvContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving males to CSV: {ex.Message}");
        }
    }

    public void SaveFemales(List<Person> people)
    {
        var femaleCsv = Path.Combine(FInfo.DirectoryName, "adultfemales.csv");

        try
        {
            var female = people
                .Where(p => p.sex == "Female" && (DateTime.Now.Year - p.dateOfBirth.Year) > 18)
                .ToList();
            var csvHeader = "Index,UserId,FirstName,LastName,Sex,Email,Phone,DateOfBirth,JobTitle";

            var csvContent = string.Join(
                Environment.NewLine,
                female.Select(p =>
                    $"{p.index},{p.userId},{p.firstName},{p.lastName},{p.sex},{p.email},{p.phone},{p.dateOfBirth},{p.jobTitle}"
                )
            );

            // Write header and content to the CSV file
            File.WriteAllText(femaleCsv, csvHeader + Environment.NewLine + csvContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving males to CSV: {ex.Message}");
        }
    }

    public void SaveDotComUSers(List<Person> people)
    {
        var dotComCsv = Path.Combine(FInfo.DirectoryName, "dotcomusers.csv");

        try
        {
            var dotCom = people
                .Where(p => p.email.EndsWith("example.com"))
                
                .Select(p =>  new { p.userId, p.email, p.phone} ).ToList();
            var csvHeader = "UserId,Email,Phone";

            var csvContent = string.Join(
                Environment.NewLine,
                dotCom.Select(p => $"{p.userId},{p.email},{p.phone}")
            );

            // Write header and content to the CSV file
            File.WriteAllText(dotComCsv, csvHeader + Environment.NewLine + csvContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving males to CSV: {ex.Message}");
        }
    }
}
