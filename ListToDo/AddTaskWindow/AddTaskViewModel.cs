using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListToDo.AddTask
{
    class AddTaskViewModel : INotifyPropertyChanged
    {

        #region Fields
        public ObservableCollection<ActivityViewModel> TasksList { get; set; } = new ObservableCollection<ActivityViewModel>();
        private string newTaskHeader = string.Empty;
        private string newTaskDescription = string.Empty;
        private ActivityViewModel selectedItem;  

        public ICommand DeleteTaskCommand { get; set; }
        public ICommand AddNewTaskCommand { get; set; }
        public ICommand TaskDoingCommand { get; set; }
        #endregion

        #region Properties
        public string NewTaskDescription 
        {
            get => newTaskDescription;
            set
            {
                newTaskDescription = value;
                OnPropertyChanged();
            }
        }

        public string NewTaskHeader 
        {
            get => newTaskHeader;
            set
            {
                newTaskHeader = value;
                OnPropertyChanged();
            }
        }

        public ActivityViewModel SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public AddTaskViewModel()
        {
            AddNewTaskCommand = new Command(AddNewTask);

            DeleteTaskCommand = new Command(DeleteTask);

            TaskDoingCommand = new Command(DoingTask);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DoingTask()
        {
            if(SelectedItem.IsSelected == true)
            {
                SelectedItem.EndDoing = DateTime.Now;

                TasksList.Remove(SelectedItem);
            }


        }


        private void AddNewTask()
        {
            var newTask = new ActivityViewModel
            {

                Header = NewTaskHeader,
                Description = NewTaskDescription,
                Created = DateTime.Now

            };

            TasksList.Add(newTask);

            NewTaskHeader = string.Empty;
            NewTaskDescription = string.Empty;


        }

        private void DeleteTask()
        {
            ObservableCollection<ActivityViewModel> DeleteTasksList = new ObservableCollection<ActivityViewModel>();

            foreach (var item in TasksList)
            {
                if (item.IsSelected)
                    DeleteTasksList.Add(item);
            }

            foreach (var item in DeleteTasksList)
            {
                TasksList.Remove(item);
            }
           

            //DeleteTasksList
            //var a = TasksList.Equals(DeleteTasksList);
            //TasksList.Remove(DeleteTasksList.);
        }


    }
}
