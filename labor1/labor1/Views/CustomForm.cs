namespace labor1.Views;

public class CustomForm : Grid
{
    public CustomForm()
    {
        RowDefinitions = new RowDefinitionCollection
        {
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = GridLength.Auto }
        };

        ColumnDefinitions = new ColumnDefinitionCollection
        {
            new ColumnDefinition { Width = GridLength.Auto },
            new ColumnDefinition { Width = GridLength.Star }
        };

        AddLabelAndEntry("Name", 0);
        AddLabelAndEntry("Age", 1);
        AddLabelAndEntry("City", 2);
        AddLabelAndEntry("E-mail", 3);
    }

    private void AddLabelAndEntry(string labelText, int row)
    {
        var label = new Label
        {
            Text = labelText,
            VerticalTextAlignment = TextAlignment.Center
        };
        Grid.SetRow(label, row);
        Grid.SetColumn(label, 0);

        var entry = new Entry
        {
            Placeholder = labelText,
            VerticalTextAlignment = TextAlignment.Center
        };
        Grid.SetRow(entry, row);
        Grid.SetColumn(entry, 1);

        Children.Add(label);
        Children.Add(entry);
    }
}