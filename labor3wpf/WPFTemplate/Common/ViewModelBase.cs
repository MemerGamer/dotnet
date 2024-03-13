namespace WPFTemplate.Common
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using WPFTemplate.ViewModel;

    public class ViewModelBase : INotifyPropertyChanged
    {
        public static MainWindowViewModel Instance { get; set; }
        public ViewModelBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
