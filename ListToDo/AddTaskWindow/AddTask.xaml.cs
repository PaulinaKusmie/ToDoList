
using ListToDo.AddTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListToDo.AddTaskWindow
{
  
    public partial class AddTask : ContentPage
    {
        public AddTask()
        {
            InitializeComponent();

            BindingContext = new AddTaskViewModel();

        }
    }
}