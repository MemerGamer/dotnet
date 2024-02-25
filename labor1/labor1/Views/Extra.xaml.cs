using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor1.Views;

public partial class Extra : ContentPage
{
    public ObservableCollection<Student> Students { get; set; }

    public Extra()
    {
        InitializeComponent();

        Students = new ObservableCollection<Student>
        {
            new Student(10, "Bob", "Smith", 80.5),
            new Student(25, "James", "Brown", 77.9),
            new Student(15, "Joe", "Martin", 52.4),
            new Student(12, "Dona", "Taylor", 53.6),
            new Student(18, "Peter", "Brian", 90.9)
        };
        
        BindingContext = this;
        
    }
}