using System;

namespace DelegatesLearn {

    // Create a delegate

    public delegate int MathDelegate(int a, int b);

    // Create a class that includes a sum method

    public class Math {
        public double Sum(double valueA, double valueB) {
            return valueA + valueB;
        }

        public int Sum(int valueA, int valueB) {
            return valueA + valueB;
        }

        
    }
    class Program {
        static void Main(string[] args) {

            // Create a new instance of the Math class
            Math math = new Math();

            // Create a delegate with Sum method as a parameter

            MathDelegate mathDelegate = new MathDelegate(math.Sum);

            // Invoke a delegate as a result variable
            double result2 = math.Sum(4.0, 6.0);
            var result = mathDelegate?.Invoke(4, 6);
            

            // Show the result in the console by using the variable
            Console.WriteLine(result);

            // Show the result in the console by using the delegate
            Console.WriteLine(mathDelegate(8, 9));
            Console.ReadLine();
        }
    }
}
