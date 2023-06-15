using System;

public class Solution {
    public static int MySqrt(int x) {
        if(x == 0)
            return 0;

        int left = 1;
        int right = x;

        while(left <= right) {
            int mid = left + (right - left) / 2;

            if(mid == x / mid)
                return mid;

            if(mid < x / mid)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return right;
    }
}

public class Program {
    public static void Main(string[] args) {

        do {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            int result = Solution.MySqrt(int.Parse(number));
            //int result = Solution.MySqrt(number);

            Console.WriteLine($"The square root of {number} is: {result}");
        } while(true);
    }
}
