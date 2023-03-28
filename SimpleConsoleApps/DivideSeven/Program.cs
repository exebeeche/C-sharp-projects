using System;

namespace DivideSeven {


    internal class Program {


        static void Main(string[] args) {
            // Input the number

            Console.WriteLine("Enter the two digits number:");
            string checkedNumber = Console.ReadLine();

            // Check the number that it has two digits
            if (checkedNumber.Length != 2) {
                Console.WriteLine("Invalid input. Please input the two digits number.");
            }

            // Parse the number into two separated values

            int firstCheckedNumber = int.Parse(checkedNumber.Substring(0, 1));
            int secondCheckedNumber = int.Parse(checkedNumber.Substring(1, 1));

            // Get the sum of two digits

            int sumCheckedNumber = firstCheckedNumber + secondCheckedNumber;

            // Checks if a number could be divided by 7

            if (sumCheckedNumber % 7 == 0) {
                Console.WriteLine($"You can divide {checkedNumber} on 7.");
            }
            else {
                Console.WriteLine($"You cannot divide {checkedNumber} on 7.");
            }

            Console.ReadLine();
        }
    }
}
