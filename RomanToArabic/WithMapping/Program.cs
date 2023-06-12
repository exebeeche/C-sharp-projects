

Dictionary<char, int> map = new Dictionary<char, int>()
{
{ 'I', 1 },
{ 'V', 5 },
{ 'X', 10 },
{ 'L', 50 },
{ 'C', 100 },
{ 'D', 500 },
{ 'M', 1000 }
};

while (true)
{
    Console.WriteLine("Enter a Roman numeral (or 'exit' to quit): ");
    string input = Console.ReadLine();

    if (input == "exit")
        return -1;

    int result = ConvertRomanToArabic(input, map);

    if (result == -1)
        Console.WriteLine("Invalid Roman Symbol!");
    else
        Console.WriteLine($"The equivalent Arabic numeral is: {result}");

}

static int ConvertRomanToArabic(string roman, Dictionary<char, int> map)
{
    int result = 0;
    int previousValue = 0;

    for (int i = roman.Length - 1; i >= 0; i--)
    {
        char currentSymbol = roman[i];
        int currentValue = map[currentSymbol];

        if (!map.ContainsKey(currentSymbol))
            return -1;

        if (currentValue < previousValue)
        {
            result -= currentValue;
        }
        else
        {
            result += currentValue;
        }

        previousValue = currentValue;
    }

    return result;
}

