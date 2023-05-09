using System;
using System.Windows.Forms;

namespace EasyEmployee {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.NameButtonClick += new NameButtonClickEventHandler(NameButton_Click);
            comboBox1.DataSource = Enum.GetValues(typeof(Position));

            //string name;
            //_employee.Deconstruct(out name, out Position position, out int salary);
        }

        /*Employee _employee = new Employee() {
            Name = "John",
            Position = Position.Manager
        };*/
        
        public bool IsSalaryValid(Employee employee) {
            var attributes = employee.GetType().GetCustomAttributes(typeof(Attribute), false);
            foreach ( var attr in attributes ) {
                if ( attr is SalaryValidation salaryValidation) {
                        return employee.Salary > salaryValidation.salary;
                    }
                }
            return false;
        }
        

        public delegate void NameButtonClickEventHandler(TextBox textBox);
        public event NameButtonClickEventHandler NameButtonClick;
        public virtual void OnNameButtonClick(Employee employee, EventArgs e) {
            if(NameButtonClick != null) {
                NameButtonClick(textBox1);
            }
        }
        int currentRowNumber = 0;
        
        private void NameButton_Click(TextBox textBox) {
            string name = textBox.Text;
            //currentRowNumber++;
            dataGridView1.Rows[currentRowNumber].Cells[0].Value = textBox.Text;
        }
        private void PositionButton_Click(ComboBox comboBox) {
            Position position = (Position)this.comboBox1.SelectedValue;
            dataGridView1.Rows[currentRowNumber].Cells[1].Value = comboBox1.Text;
        }
        private void SalaryButton_Click(TextBox textBox) {
            int salary = int.Parse(textBox.Text);
            dataGridView1.Rows[currentRowNumber].Cells[2].Value = textBox.Text;
        }

        public void button1_Click(object sender, EventArgs e) {
            NameButton_Click(textBox1);
        }

        public void button2_Click(object sender, EventArgs e) {
            PositionButton_Click(comboBox1);
        }

        public void button3_Click(object sender, EventArgs e) {
            SalaryButton_Click(textBox3);
            //taGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            dataGridView1.Rows.Add();
            //taGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //taGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
