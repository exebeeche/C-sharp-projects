using System;
using System.Linq;

public class LongestCommonPrefix
{
    public static string FindLongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return ""; // Return empty string if the input array is null or empty
        }

        string prefix = strs.First(); // Initialize prefix with the first string in the array

        // Compare prefix with each string in the array
        // Take the common characters until a mismatch is found or the prefix is empty
        prefix = strs.Aggregate(prefix, (currentPrefix, str) => string.Join("", currentPrefix.TakeWhile((c, i) => i < str.Length && c == str[i])));

        return prefix; // Return the longest common prefix
    }

    public static void Main()
    {
        string[] input = { "flower", "flow", "flight" };
        string longestCommonPrefix = FindLongestCommonPrefix(input);
        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }
}
