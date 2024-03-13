using WPFTemplate.Common;
using WPFTemplate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPFTemplate.ViewModel
{
    public class AddItemViewModel : ViewModelBase
    {
        private User newUser;
        public RelayCommand SaveDataCommand { get; set; }
        public AddItemViewModel()
        {
            this.NewUser = new User();
            this.SaveDataCommand = new RelayCommand(this.SaveDataCommandExecute);
        }

        private void SaveDataCommandExecute()
        {
            if (this.NewUser.UserId != null && this.NewUser.FirstName != null && this.NewUser.LastName != null && this.NewUser.City != null && this.NewUser.State != null && this.NewUser.Country != null)
            {
                Instance.UserList.Add(this.NewUser);
                ViewService.CloseDialog(this);
            }
            else
            {
                // show error
                string errorMessage = "All fields are required!";
                System.Windows.MessageBox.Show(errorMessage, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
        public User NewUser
        {
            get { return newUser; }
            set
            {
                newUser = value;
                this.RaisePropertyChanged();
            }
        }
    }
}