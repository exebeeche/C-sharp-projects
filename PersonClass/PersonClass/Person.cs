using System;
namespace PersonClass {
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void PrintName() {
            Console.WriteLine($"My name is {FirstName}");
        }
    }
}