using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OhII_nam
{
    public class MainWindowViewModel : BaseViewModel
    {
        private MainWindow _mainWindow;
        private string _userName = "001";
        private string _password = "squidGame";
        public ICommand AddUserCommand { get; set; }
        public ICommand DeleteUserCommand { get; set; }
        public ICommand GetAllGamersCommand { get; set; }
        public MainWindowViewModel(MainWindow window)
        {
            _mainWindow = window;
            GlobalVariables.MainWindow = window;

            AddUserCommand = new RelayCommand(AddUser);
            DeleteUserCommand = new RelayCommand(DeleteUser);
            GetAllGamersCommand = new RelayCommand(GetAllGamers);
        }

        private void GetAllGamers(object obj)
        {
            GlobalVariables.Gamer.GetAllUsers(_userName, _password);
        }

        private void DeleteUser(object obj)
        {
            GlobalVariables.Gamer.UnSubscribe(_userName);
        }

        private void AddUser(object obj)
        {
            GlobalVariables.Gamer.Subscribe(_userName);
        }
    }

}
