Console.WriteLine("Roman to Arabic Converter");
Console.WriteLine("-------------------------");

while (true)
{
    Console.Write("Enter a Roman numeral (or 'exit' to quit): ");
    string input = Console.ReadLine().ToUpper();

    if (input == "EXIT")
        break;

    int result = ConvertRomanToArabic(input);
    if (result == -1)
        Console.WriteLine("Invalid Roman numeral!");
    else
        Console.WriteLine($"The equivalent Arabic numeral is: {result}");
}

static int ConvertRomanToArabic(string roman)
{
    int result = 0;
    int previousValue = 0;

    for (int i = roman.Length - 1; i >= 0; i--)
    {
        int currentValue = GetRomanValue(roman[i]);

        if (currentValue == -1)
            return -1;

        if (currentValue < previousValue)
            result -= currentValue;
        else
            result += currentValue;

        previousValue = currentValue;
    }

    return result;
}

static int GetRomanValue(char c)
{
    switch (c)
    {
        case 'I':
            return 1;
        case 'V':
            return 5;
        case 'X':
            return 10;
        case 'L':
            return 50;
        case 'C':
            return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
        default:
            return -1;
    }
}
