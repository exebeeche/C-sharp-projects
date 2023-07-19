public class Solution
{
    public static bool IsPowerOfTwo(int n)
    {
        //if (n > 0)
        //{
        //    return (n & (n - 1)) == 0;
        //}

        //return false;

        if (n == 0)
        {
            return false;
        }

        while (n!=1)
        {
            if (n%2!=0)
            {
                return false;
            }
            else
            {
                n = n / 2;
            }
        }
        return true;
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter an integer: ");
            int input = int.Parse(Console.ReadLine());

            bool isPowerOfTwo = IsPowerOfTwo(input);

            Console.WriteLine($"Is {input} a power of two? {isPowerOfTwo}");
        }
        
    }
}

