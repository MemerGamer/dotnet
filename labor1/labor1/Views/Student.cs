namespace labor1.Views;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Percentage { get; set; }

    public Student(int id, string firstName, string lastName, double percentage)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Percentage = percentage;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} (ID: {Id}) has a percentage of {Percentage}.";
    }
}