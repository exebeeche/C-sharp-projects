using System.Windows;
using System.Windows.Data;
using Teapot_wpf.Model;
using Teapot_wpf.Presenter;

namespace Teapot_wpf.View {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Teapot teapot = new Teapot(0);
            Present presenter = new Present(teapot);
                       
        }

        private Teapot teapot;
        private Present presenter;

        private void buttonTemp_Click(object sender, RoutedEventArgs e) {

        }
    }
}
