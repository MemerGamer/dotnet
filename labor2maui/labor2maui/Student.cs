namespace labor2maui
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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
            return "Id: " + Id + " FirstName: " + FirstName 
                + " LastName: " + LastName +
                " Percentage: " + Percentage; 
        }
    }
}
