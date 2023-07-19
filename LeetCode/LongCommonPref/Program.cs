using System;

public class LongestCommonPrefix
{
    public static string FindLongestCommonPrefix(string[] strs)
    {
        int length = strs.Length;
        if (length == 0) return "";
        if (length == 1) return strs[0];

        int count = strs[0].Length;
        string answer = strs[0];
        for (int i = 1; i < length; i++)
        {
            int strsLength = strs[i].Length;
            for (int j = 0; j < count; j++)
            {
                if (j == strsLength || strs[i][j] != answer[j])
                {
                    answer = answer.Substring(0, j);
                    count = answer.Length;
                }
            }
        }

        return answer;
    }

    public static void Main()
    {
        string[] input = { "flower", "flow", "flomster", "floyd" };
        string longestCommonPrefix = FindLongestCommonPrefix(input);
        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }
}
