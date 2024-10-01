using System.IO;
namespace PeopleManagement;

public class CSVParser
{
    string filePath;
    FileInfo FInfo => new(filePath);

    public CSVParser(string FPath)
    {
        filePath = FPath;
    }

    public List<Person> ParseCSV()
    {
        var lines = File.ReadAllLines(filePath);
        List<Person> people = new List<Person>();

        foreach (var dataLine in lines.Skip(1))
        {
            var dataParts = dataLine.Split(",");

            try
            {
                int index = int.Parse(dataParts[0]);
                DateTime dob = DateTime.Parse(dataParts[7]);
                var person = new Person(
                    index,
                    dataParts[1],
                    dataParts[2],
                    dataParts[3],
                    dataParts[4],
                    dataParts[5],
                    dataParts[6],
                    dob,
                    dataParts[8]
                );
                people.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing line: {dataLine}. Exception: {ex.Message}");
            }
        }

        return people;
    }
}
