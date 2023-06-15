using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace TaskPlanning {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private ObservableCollection<Task> tasks;
        private TaskViewModel viewModel;

        public MainWindow() {
            InitializeComponent();
            tasks = new ObservableCollection<Task>();
            taskListView.ItemsSource = tasks;
            viewModel = new TaskViewModel();
            DataContext = viewModel;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e) {
            string taskName = taskTextBox.Text;
            DateTime deadline = deadlineDatePicker.SelectedDate ?? DateTime.MinValue;

            viewModel.AddTask(taskName, deadline);

            
            taskTextBox.Text = string.Empty;
                deadlineDatePicker.SelectedDate = null;
            }
        private void MarkTaskAsDone_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            Task task = (Task)button.DataContext;
            task.IsDone = true;
        }

    }
}

