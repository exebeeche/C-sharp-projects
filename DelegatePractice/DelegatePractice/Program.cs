using System;
using System.Reflection;

namespace DelegatePractice {

    public delegate string fullNameChangedDelegate(string fullName);
    public delegate string[] positionChangedDelegate(string[] Position);
    public delegate int salaryChangedDelegate(int salary);
    public enum JobTitle {
        CEO = 0,
        CTO = 1,
        Accounter = 2,
        Developer = 3,
        Anykey = 4,
    }

    public class Employee {

        public Employee(string name, int salary, int position, JobTitle job) {
            this.fullNameEmployee = name;
            this.salaryEmployee = salary;
            this.CurrentPosition = PositionEmployee[position];
            this.JobTitle = job;
        }

        string fullNameEmployee;
        int salaryEmployee;
        string[] PositionEmployee = new string[5] {
        "CEO", "CTO", "Accounter", "Developer", "Anykey"
        };
        string CurrentPosition;
        JobTitle JobTitle;

        public void ChangeName(string newNameEmployee) {
            this.fullNameEmployee = newNameEmployee;
        }
        public void ChangePosition(int index) {
            CurrentPosition = PositionEmployee[index];
        }

        public void ChangeJob(JobTitle jobTitle) {
            JobTitle = jobTitle;
        }

        public void ChangeSalary(int newSalaryEmployee) {
             this.salaryEmployee = newSalaryEmployee;
        }

        public void PrintInfo () {
            Console.WriteLine($"Name: {fullNameEmployee}" + $"  Salary: {salaryEmployee}" + $"  Position:  {CurrentPosition}" + $"  Job: {JobTitle}");
        }

    }
    public class Program {
        static void Main(string[] args) {
            Employee employee = new Employee("Ivanov", 20000, 0, JobTitle.Anykey);

            employee.PrintInfo();
            Console.ReadLine();

        }
    }
}
