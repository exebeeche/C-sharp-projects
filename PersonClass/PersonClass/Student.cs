using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass {
    public class Student : Person {
        public string SchoolName { get; set; }

        public new void PrintName() {
            Console.WriteLine($"I am a student. My name is {FirstName}!");
        }

        public void Learn() {
            Console.WriteLine($"I am learning at {SchoolName}!");
        }
    }
}
