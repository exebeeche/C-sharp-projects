using System;

namespace Calculator {
    internal class Program {
        static void Main(string[] args) {

            double firstNumber, secondNumber;
            char Operation;
            Console.WriteLine("Enter the first number:");
            firstNumber= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            secondNumber= double.Parse(Console.ReadLine());

            Console.WriteLine("Select the operation. Valid values are +, -, *, /.");
            Operation = char.Parse(Console.ReadLine());

            double Result = 0;

            switch (Operation) {
                case'+':
                    Result = firstNumber + secondNumber;
                    break;
                case'-':
                    Result = firstNumber - secondNumber;
                    break;
                case'*':
                    Result = firstNumber * secondNumber;
                    break;
                case'/':
                    if(secondNumber == 0) {
                        Console.WriteLine("You cannot divide on zero!");
                    } else {
                        Result = firstNumber / secondNumber;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
                    
            }
            Console.WriteLine($"Result is: {Result}");
            Console.ReadLine();
        }
    }
}
