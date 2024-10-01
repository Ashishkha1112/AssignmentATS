namespace PeopleManagement;


class Prgram
{
    static void Main(string[] args){
        
            string filePath = @"G:\Trainning\AssignmentATS\PeopleManagement\FileHandling\Data\People.csv";
            var parser = new CSVParser(filePath);
            var peopleReport = new PeopleReport(filePath);
            
            
            List<Person> people = parser.ParseCSV();
            peopleReport.SaveMales(people);
              peopleReport.SaveFemales(people);
              peopleReport.SaveDotComUSers(people);
    
    
 }
}