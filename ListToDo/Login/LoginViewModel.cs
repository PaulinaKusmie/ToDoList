using ListToDo.AddTask;
using ListToDo.AddTaskWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListToDo.Login
{

    
    class LoginViewModel
    {

        public ICommand LoginCommand { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }


        public LoginViewModel()
        {
            LoginCommand = new Command(LoginClickAsync);

        }

        INavigation Navigation => Application.Current.MainPage.Navigation;
        private async void LoginClickAsync()
        {

            if(Login == "Paulina" && Password == "nopass")
            {
                await Navigation.PushModalAsync(new AddTaskWindow.AddTask());
            }
            else
            {

                 await App.Current.MainPage.DisplayAlert("Alert", "Incorrect data", "OK");
            }
        }

       
    }

    
}
