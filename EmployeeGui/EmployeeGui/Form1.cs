using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmployeeGui {

    public partial class Form1 : Form {
        private BindingList<Employee> employees = new BindingList<Employee>();

        public Form1() {
            InitializeComponent();
            InitializeDataGridView();            

        }
        private void InitializeDataGridView() {
            dataGridView1.DataSource = employees;
        }

    }
    public enum Position {
        Manager,
        Developer,
        Tester,
        Designer,
        TechWriter
    }
    public class Employee {
        private string name;
        private Position position;
        private int salary;

        public event EventHandler NameChanged;
        public event EventHandler PositionChanged;
        public event EventHandler SalaryChanged;

        public string Name {
            get { return name; }
            set {
                name = value;
                if(NameChanged != null) {
                    OnNameChanged(EventArgs.Empty);
                }
            }
        }
        public Position Position {
            get { return position; }
            set {
                position = value;
                if(PositionChanged != null) {
                    OnPositionChanged(EventArgs.Empty);
                }
            }
        }
        public int Salary {
            get { return salary; }
            set {
                salary = value;
                if(SalaryChanged != null) {
                    OnSalaryChanged(EventArgs.Empty);
                }
            }
        }
        protected virtual void OnNameChanged(EventArgs e) {
            if(NameChanged != null) {
                NameChanged?.Invoke(this, e);
            }
        }
        protected virtual void OnPositionChanged(EventArgs e) {
            if(PositionChanged != null) {
                PositionChanged?.Invoke(this, e);
            }
        }
        protected virtual void OnSalaryChanged(EventArgs e) {
            if(SalaryChanged != null) {
                SalaryChanged?.Invoke(this, e);
            }
        }

    }
}

