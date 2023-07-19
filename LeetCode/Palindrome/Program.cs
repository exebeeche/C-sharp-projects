using System.Text.RegularExpressions;

public class PalindromeSolution
{
    public static bool IsPalindrome(string s)
    {
        
        s = s.ToLower();
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        if (s == string.Empty)
        {
            return true;
        }

        Console.WriteLine(s);

        int b = 0;
        int e = s.Length - 1;

        while (b < e)
        {
            if (s.ElementAt(b) != s.ElementAt(e))
            {
                return false;
            }

            b++;
            e--;

        }

        return true;

        //string cleanedString = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

        //// Compare the cleaned string with its reverse
        //string reversedString = new string(cleanedString.Reverse().ToArray());

        //return cleanedString == reversedString || cleanedString == "";

    }

    public static void Main(string[] args)
    {
        string input = " ";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine(isPalindrome);

    }
}