using WPFTemplate.Common;
using WPFTemplate.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPFTemplate.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<User> userList;
        private User selectedUser;
        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand ClearListCommand { get; set; }
        public RelayCommand DeleteItemCommand { get; set; }
        public RelayCommand AddItemCommand { get; set; }

        public MainWindowViewModel()
        {
            this.UserList = new ObservableCollection<User>();
            this.LoadDataCommand = new RelayCommand(this.LoadDataCommandExecute);
            this.ClearListCommand = new RelayCommand(this.ClearListCommandExecute);
            this.DeleteItemCommand = new RelayCommand(this.DeleteItemCommandExecute);
            this.AddItemCommand = new RelayCommand(this.AddItemCommandExecute);
        }

        private void AddItemCommandExecute()
        {
            AddItemViewModel aiViewModel = new AddItemViewModel();
            ViewService.ShowDialog(aiViewModel);
        }
        private void DeleteItemCommandExecute()
        {
            if (this.SelectedUser != null)
            {
                this.UserList.Remove(this.SelectedUser);
            }
        }
        private void ClearListCommandExecute()
        {
            this.UserList.Clear();
        }
        private void LoadDataCommandExecute()
        {
            if (this.userList.Count > 0)
            {
                return;
            }

            foreach (string line in System.IO.File.ReadLines(@"Users.txt"))
            {
                string[] words = line.Split(',');

                User user = new User();
                user.UserId = Int32.Parse(words[0]);
                user.FirstName = words[1];
                user.LastName = words[2];
                user.City = words[3];
                user.State = words[4];
                user.Country = words[5];

                this.userList.Add(user);
            }
        }

        public ObservableCollection<User> UserList
        {
            get { return userList; }
            set
            {
                userList = value;
                this.RaisePropertyChanged();
            }
        }

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                this.RaisePropertyChanged();
            }
        }
    }
}