public class Person
{
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Sex { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string JobTitle { get; set; }

    public Person(string user_id, string fname, string lname, string sex, string email, string phone, DateTime dob, string jobTitle)
    {
        UserId = user_id;
        FirstName = fname;
        LastName = lname;
        Sex = sex;
        Email = email;
        Phone = phone;
        DateOfBirth = dob;
        JobTitle = jobTitle;
    }
}
