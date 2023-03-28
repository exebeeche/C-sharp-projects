using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEmployee {
    public enum Position {
        Manager,
        Developer,
        Tester,
        Designer,
        TechWriter
    }
    public class Employee {

        public Employee(string name, Position position, int salary) {
            this.Name = name;
            this.Position = position;
            this.Salary = salary;
        }

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
