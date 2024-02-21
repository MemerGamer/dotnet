using System.Reflection;

namespace labor1.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;

        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            labelke.Text = "Hello user: " + e.NewTextValue;
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            DisplayAlert("title","Szia " + entry.Text,"cancel");
        }
    }
}