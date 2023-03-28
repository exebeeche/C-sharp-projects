using System;

namespace CheckCapitalLetter {
    internal class Program {
        static void Main(string[] args) {

            // Input a symbol
            do {
                Console.WriteLine("Enter a letter:");
                char checkedLetter = Console.ReadKey().KeyChar;
                Console.ReadLine();

                // Check the letter

                //char.IsUpper(checkedLetter) ? Console.WriteLine("The input symbol is an uppercase letter.") : Console.WriteLine("The input symbol is a capital letter.");

                if(char.IsUpper(checkedLetter)) {
                    Console.WriteLine("The input symbol is an uppercase letter.");
                } else {
                    Console.WriteLine("The input symbol is a capital letter.");
                }
            } while (true);
            }
    }
}
