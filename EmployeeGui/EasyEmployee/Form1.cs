using System;
using System.Windows.Forms;

namespace EasyEmployee {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.NameButtonClick += new NameButtonClickEventHandler(NameButton_Click);
            comboBox1.DataSource = Enum.GetValues(typeof(Position));
        }

        public delegate void NameButtonClickEventHandler(TextBox textBox);
        public event NameButtonClickEventHandler NameButtonClick;
        public virtual void OnNameButtonClick(Employee employee, EventArgs e) {
            if(NameButtonClick != null) {
                NameButtonClick(textBox1);
            }
        }


        int currentRowNumber = -1;
        
        public void NameButton_Click(TextBox textBox) {
            string name = textBox.Text;
            currentRowNumber++;
            dataGridView1.Rows[currentRowNumber].Cells[0].Value = textBox.Text;
        }
        public void PositionButton_Click(ComboBox comboBox) {
            Position position = (Position)this.comboBox1.SelectedValue;
            dataGridView1.Rows[currentRowNumber].Cells[1].Value = comboBox1.Text;
        }
        public void SalaryButton_Click(TextBox textBox) {
            int salary = int.Parse(textBox.Text);
            dataGridView1.Rows[currentRowNumber].Cells[2].Value = textBox.Text;
        }

        private void button1_Click(object sender, EventArgs e) {
            NameButton_Click(textBox1);
        }

        private void button2_Click(object sender, EventArgs e) {
            PositionButton_Click(comboBox1);
        }

        private void button3_Click(object sender, EventArgs e) {
            SalaryButton_Click(textBox3);
        }
    }
}
