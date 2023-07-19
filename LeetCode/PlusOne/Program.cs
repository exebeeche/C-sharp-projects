using System;

public class PlusOneSolution
{
    public static int[] PlusOne(int[] digits)
    {
        for (int index = digits.Length - 1; index >= 0; index--)
        {
            if(digits[index] < 9)
            {
                digits[index]++;
                return digits;
            }
            digits[index] = 0;
        }
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
    public static void Main()
    {
        int[] input = { 9, 9, 3, 9, 9, 9 };
        int[] resultPlusOne = PlusOne(input);
        for (int i = 0; i < resultPlusOne.Length; i++)
        {
            Console.WriteLine(resultPlusOne[i]);
        }
        
    }
}