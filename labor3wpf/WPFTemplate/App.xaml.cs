using System.Configuration;
using System.Data;
using System.Windows;
using WPFTemplate.Common;
using WPFTemplate.View;
using WPFTemplate.ViewModel;

namespace WPFTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.Initialize();
            this.OpenMainWindow();
        }

        private void Initialize()
        {
            ViewService.RegisterView(typeof(MainWindowViewModel),
            typeof(MainWindow));
        }
        private void OpenMainWindow()
        {
            MainWindow mainWindow = new MainWindow();
            MainWindowViewModel mainWindowViewModel = new
            MainWindowViewModel();
            ViewService.AddMainWindowToOpened(mainWindowViewModel,
            mainWindow);
            ViewService.ShowDialog(mainWindowViewModel);
        }
    }

}
