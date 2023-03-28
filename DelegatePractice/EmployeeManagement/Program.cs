using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement {

    // Create the Employee class
    public class Employee {
        // Create employee properties
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public decimal EmployeeSalary { get; set; }

        // Create delegates
        public delegate void EmployeeSalaryChangedEventHandler(object sender, EmployeeSalaryChangedEventHandler e);
        public delegate void EmployeePositionChangedEventHandler(object sender, EmployeePositionChangedEventHandler e);
        public delegate void EmployeeNameChangedEventHandler(object sender, EmployeeNameChangedEventHandler e);

        // Create events for changes
        public event EmployeeNameChangedEventHandler EmployeeNameChanged;
        public event EmployeeSalaryChangedEventHandler EmployeeSalaryChanged;
        public event EmployeePositionChangedEventHandler EmployeePositionChanged;

        // Create methods for changes
        public void ChangeEmployeeSalary(decimal newEmployeeSalary) {
            decimal oldEmployeeSalary = EmployeeSalary;
            EmployeeSalary = newEmployeeSalary;

            OnEmployeeSalaryChanged(new EmployeeSalaryChangedEventArgs { OldEmployeeSalary = oldEmployeeSalary, NewEmployeeSalary = newEmployeeSalary });
        }
        public void ChangeEmployeePosition(string newEmployeePosition) {
            string oldEmployeePosition = EmployeePosition;
            EmployeePosition = newEmployeePosition;

            OnEmployeePositionChanged(new EmployeePositionChangedEventArgs { OldEmployeePosition = oldEmployeePosition, NewEmployeePosition = newEmployeePosition });
        }
        public void ChangeEmployeeName(string newEmployeeName) {
            string oldEmployeeName = EmployeeName;
            EmployeeName = newEmployeeName;

            OnEmployeeNameChanged(new EmployeeNameChangedEventArgs { OldEmployeeName = oldEmployeeName, NewEmployeeName = newEmployeeName });
        }

        // Create methods for the event fire
        public void OnEmployeeSalaryChanged(EmployeeSalaryChangedEventArgs e) {
            EmployeeSalaryChanged?.Invoke(this, e);
        }
        public void OnEmployeePositionChanged(EmployeePositionChangedEventArgs e) {
            EmployeePositionChanged?.Invoke(this, e);
        }
        public void OnEmployeeNameChanged(EmployeeNameChangedEventArgs e) {
            EmployeeNameChanged?.Invoke(this, e);
        }

        // Create classes for the event args storing
        public class EmployeeSalaryChangedEventArgs : EventArgs {
            public decimal OldEmployeeSalary { get; set; }
            public decimal NewEmployeeSalary { get; set; }
        }
        public class EmployeePositionChangedEventArgs : EventArgs {
            public string OldEmployeePosition { get; set; }
            public string NewEmployeePosition { get; set; }
        }
        public class EmployeeNameChangedEventArgs : EventArgs {
            public string OldEmployeeName { get; set; }
            public string NewEmployeeName { get; set; }
        }

        class Program {
            static void Main(string[] args) {
                var employee = new Employee();
                {
                    string EmployeeName = "John Snow";
                    string EmployeePosition = "CEO";
                    decimal EmployeeSalary = 1000000;
                };
                employee.EmployeeSalaryChanged += Employee_SalaryChanged;
                employee.EmployeeNameChanged += Employee_NameChanged;
                employee.EmployeePositionChanged += Employee_PositionChanged;

                employee.ChangeEmployeeName("John Stark");
                employee.ChangeEmployeePosition("CTO");
                employee.ChangeEmployeeSalary(2000000);

                Console.ReadLine();
            }

            public static void Employee_SalaryChanged(object sender, EmployeeSalaryChangedEventArgs e) {
                Console.WriteLine($"Salary changed from {e.OldEmployeeSalary} to {e.NewEmployeeSalary}");
            }
            public static void Employee_NameChanged(object sender, EmployeeNameChangedEventArgs e) {
                Console.WriteLine($"Salary changed from {e.OldEmployeeName} to {e.NewEmployeeName}");
            }
            public static void Employee_PositionChanged(object sender, EmployeePositionChangedEventArgs e) {
                Console.WriteLine($"Salary changed from {e.OldEmployeePosition} to {e.NewEmployeePosition}");
            }
        }
    }
}
