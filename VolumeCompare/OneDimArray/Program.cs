using System;

namespace OneDimArray {
    class Program {
        static void Main(string[] args) {

            int[] array = new int[5];
            array[0] = 1;
            array[1] = 20;
            array[2] = 40;
            array[3] = 60;
            array[4] = 80;

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("The array unit   " + i + "   " + array[i]);
            }
            Console.ReadLine();
        }
    }
}
