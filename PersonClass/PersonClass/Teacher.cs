using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass {
    public class Teacher : Person {
        public string SchoolName { get; set; }

        public override void PrintName() {
            Console.WriteLine($"My name is {FirstName}");
            Console.WriteLine($"I am a Professor!");
        }

        public void Teach() {
            Console.WriteLine($"I am teaching at {SchoolName}");
        }
    }
}
