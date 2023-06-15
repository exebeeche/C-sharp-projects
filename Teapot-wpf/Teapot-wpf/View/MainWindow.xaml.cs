using System.Windows;
using Teapot_wpf.Presenter;

namespace Teapot_wpf.View {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Present presenter = new Present(new Model.Teapot(), this);
                       
        }
        public string TextBoxTempText { 
            get { 
                return textBoxTemp.Text; 
            } 
            set { 
                textBoxTemp.Text = value; 
            } 
        }
        public string TextBoxVolumeText {
            get {
                return textBoxVolume.Text;
            }
            set {
                textBoxVolume.Text = value;
            }
        }
        public Model.Model ComboBoxModelText {
            get {
                return (Model.Model)comboBoxModel.SelectedItem ;
            }
            set {
                comboBoxModel.SelectedItem = value;
            }
        }
        
        public string TextBoxMaxVolumeText {
            get {
                return textBoxVolumeLimit.Text;
            }
            set {
                textBoxVolumeLimit.Text = value;
            }
        }

        private Present presenter;

        private void buttonTemp_Click(object sender, RoutedEventArgs e) {
            presenter.UpdateTPInfo(sender, e);
        }
    }
}
