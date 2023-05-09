using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeaPot {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\github\\C-sharp-projects\\EmployeeGui\\TeaPot\\img\\teapot.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = panel1;
            panel1.Controls.Add(pictureBox1);
            comboBoxModel.DataSource = Enum.GetValues(typeof(Model));
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            teapot1.TempChanged += UpdateTemp;
            teapot1.VolumeChanged += UpdateVolume;
            teapot1.TempMax += MaximumTemp;
            teapot1.VolumeMax += MaximumVolume;
            teapot1.ModelChanged += RefreshModel;
        }
        Teapot teapot1 = new Teapot(20);
        private void button1_Click(object sender, EventArgs e) {
            
            teapot1.ChangeTemp(sender, e);
        }
        public void MaximumTemp() {
            MessageBox.Show("Maximum temperature reached!");
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) {
            teapot1.ChangeVolume(sender, e);
        }
        public void MaximumVolume() {
            MessageBox.Show("Maximum volume reached!");
            button2.Enabled = false;
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e) {
            teapot1.ChooseModel((ComboBox)sender);            
            textBox1.Text = $"Selected model: {teapot1.Model.ToString()}";
            textBoxVolLimit.Text = $"Volume limit: {teapot1.maxVolume.ToString()}";
            textBoxTempLimit.Text = $"Temp limit: {teapot1.maxTemp.ToString()}";
        }

        public void UpdateTemp(object sender, TemperatureEventArgs e) { 
            textBoxTemp.Text = "Current temperature is " + e.Temp.ToString();
        }

        public void UpdateVolume(object sender, VolumeEventArgs e) {
            textBoxVolume.Text = "Current volume is " + e.Volume.ToString();
        }

        public void RefreshModel() {
            button1.Enabled = true;
            button2.Enabled = true;
            textBoxVolume.Text = "Current volume is O L";
            textBoxTemp.Text = "Current temperature is 20C";
        }

    }
}
