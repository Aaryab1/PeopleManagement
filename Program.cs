var parser = new CSVParser();
string filepath = @"C:\Users\aryab\OneDrive\Desktop\dotnet\PeopleManagement\FileIO\Data\People.csv";
var people = parser.ParseCsv(filepath);

var report = new PeopleReport();
report.SaveMales(people);
report.SaveFemales(people);
report.SaveDotComUsers(people);

