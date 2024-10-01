public class CSVParser
{
    public List<Person> ParseCsv(string filepath)
    {
        var people = new List<Person>();
        var lines = File.ReadAllLines(filepath);
        var header = lines[0];
        var headerParts = header.Split(',');
        
        foreach(var line in lines.Skip(1))
        {
            var parts = line.Split(',');
            var person = new Person(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], DateTime.Parse(parts[7]), parts[8]);
            people.Add(person);
        }
        return people;
    }
}