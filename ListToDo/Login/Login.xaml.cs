using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListToDo.Login
{
   
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            BindingContext = new ListToDo.Login.LoginViewModel();
            InitializeComponent();
        }
    }
}