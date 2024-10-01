public class PeopleReport
{
    public void SaveMales(List<Person> people)
    {
        string filepath = @"C:\Users\aryab\OneDrive\Desktop\dotnet\PeopleManagement\FileIO\Data\Males.csv";
        var fileInfo = new FileInfo(filepath);
        Console.WriteLine(fileInfo.DirectoryName);
        var males = people.Where(p => p.Sex == "Male");
        string newRow = "";
        string header = $"UserId,FirstName,LastName,Sex,Email,Phone,DateOfBirth,JobTitle";
        File.AppendAllText(filepath, header + Environment.NewLine);
        foreach (var person in males)
        {
            
            try
            {
                newRow = $"{person.UserId},{person.FirstName},{person.LastName},{person.Sex},{person.Email},{person.Phone},{person.DateOfBirth},{person.JobTitle}";
                File.AppendAllText(filepath, newRow + Environment.NewLine);

            }
            catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
        
    }

    public void SaveFemales(List<Person> people)
    {
        string filepath = @"C:\Users\aryab\OneDrive\Desktop\dotnet\PeopleManagement\FileIO\Data\AdultFemales.csv";
        var females = people.Where(p => p.DateOfBirth.AddYears(18) <= DateTime.Now && p.Sex == "Female");
        string newRow = "";
        string header = $"UserId,FirstName,LastName,Sex,Email,Phone,DateOfBirth,JobTitle";
        File.AppendAllText(filepath, header + Environment.NewLine);
        foreach (var person in females)
        {
            
            try
            {
                newRow = $"{person.UserId},{person.FirstName},{person.LastName},{person.Sex},{person.Email},{person.Phone},{person.DateOfBirth},{person.JobTitle}";
                File.AppendAllText(filepath, newRow + Environment.NewLine);

            }
            catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
        
        
    }

    public void SaveDotComUsers(List<Person> people)
    {
        string filepath = @"C:\Users\aryab\OneDrive\Desktop\dotnet\PeopleManagement\FileIO\Data\dotComUsers.csv";
        var dotComUsers = people.Where(p => p.Email.EndsWith("@example.com"));
        string newRow = "";
        string header = $"UserId,Email,Phone Number";
        File.AppendAllText(filepath, header + Environment.NewLine);
        foreach (var person in dotComUsers)
        {
            
            try
            {
                newRow = $"{person.UserId},{person.Email},{person.Phone}";
                File.AppendAllText(filepath, newRow + Environment.NewLine);

            }
            catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
        
    }
}