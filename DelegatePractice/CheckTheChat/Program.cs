using System;

public class SalaryChangedEventArgs : EventArgs {
    public decimal OldSalary { get; set; }
    public decimal NewSalary { get; set; }
}

public class PositionChangedEventArgs : EventArgs {
    public string OldPosition { get; set; }
    public string NewPosition { get; set; }
}

public class LastNameChangedEventArgs : EventArgs {
    public string OldLastName { get; set; }
    public string NewLastName { get; set; }
}

public class Employee {
    private decimal salary;
    private string position;
    private string lastName;

    public string FirstName { get; set; }

    public string LastName {
        get { return lastName; }
        set {
            if(value != lastName) {
                var e = new LastNameChangedEventArgs {
                    OldLastName = lastName,
                    NewLastName = value
                };
                lastName = value;
                LastNameChanged?.Invoke(this, e);
            }
        }
    }

    public string Position {
        get { return position; }
        set {
            if(value != position) {
                var e = new PositionChangedEventArgs {
                    OldPosition = position,
                    NewPosition = value
                };
                position = value;
                PositionChanged?.Invoke(this, e);
            }
        }
    }

    public decimal Salary {
        get { return salary; }
        set {
            if(value != salary) {
                var e = new SalaryChangedEventArgs {
                    OldSalary = salary,
                    NewSalary = value
                };
                salary = value;
                SalaryChanged?.Invoke(this, e);
            }
        }
    }

    public delegate void SalaryChangedEventHandler(object sender, SalaryChangedEventArgs e);
    public delegate void PositionChangedEventHandler(object sender, PositionChangedEventArgs e);
    public delegate void LastNameChangedEventHandler(object sender, LastNameChangedEventArgs e);

    public event SalaryChangedEventHandler SalaryChanged;
    public event PositionChangedEventHandler PositionChanged;
    public event LastNameChangedEventHandler LastNameChanged;

    public void ChangeSalary(decimal newSalary) {
        Salary = newSalary;
    }

    public void ChangePosition(string newPosition) {
        Position = newPosition;
    }

    public void ChangeLastName(string newLastName) {
        LastName = newLastName;
    }
}

class Program {
    static void Main(string[] args) {
        // Create a new employee
            Employee employee = new Employee {
            FirstName = "John",
            LastName = "Doe",
            Position = "Software Engineer",
            Salary = 100000
        };

        // Register event handlers for the employee's events
        employee.SalaryChanged += Employee_SalaryChanged;
        employee.PositionChanged += Employee_PositionChanged;
        employee.LastNameChanged += Employee_LastNameChanged;

        // Change the employee's salary, position, and last name
        employee.ChangeSalary(110000);
        employee.ChangePosition("Senior Software Engineer");
        employee.ChangeLastName("Smith");

        Console.ReadKey();
    }

    private static void Employee_SalaryChanged(object sender, SalaryChangedEventArgs e) {
        Console.WriteLine($"Salary changed from {e.OldSalary:C} to {e.NewSalary:C}");
    }

    private static void Employee_PositionChanged(object sender, PositionChangedEventArgs e) {
        Console.WriteLine($"Position changed from {e.OldPosition} to {e.NewPosition}");
    }

    private static void Employee_LastNameChanged(object sender, LastNameChangedEventArgs e) {
        Console.WriteLine($"Last name changed from {e.OldLastName} to {e.NewLastName}");
    }
}