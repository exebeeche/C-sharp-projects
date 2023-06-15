using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanning {
    public class TaskViewModel : INotifyPropertyChanged {
        private ObservableCollection<Task> tasks;

        public ObservableCollection<Task> Tasks {
            get { return tasks; }
            set {
                tasks = value;
                OnPropertyChanged();
            }
        }

        public TaskViewModel() {
            Tasks = new ObservableCollection<Task>();
        }

        public void AddTask(string taskName, DateTime deadline) {
            if(!string.IsNullOrEmpty(taskName) && deadline != DateTime.MinValue) {
                Task newTask = new Task {
                    TaskName = taskName,
                    Deadline = deadline,
                    IsDone = false
                };

                Tasks.Add(newTask);
            }
        }

        public void MarkTaskAsDone(Task task) {
            task.IsDone = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
