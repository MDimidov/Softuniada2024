int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

List<int> specialNumbers = new();

for (int i = n; i <= m; i++)
{
    if (IsSpecialNumber(i))
    {
        specialNumbers.Add(i);
    }
}

Console.WriteLine(string.Join(Environment.NewLine, specialNumbers));

bool IsSpecialNumber(int number)
{
    int prevDigit = number % 10;
    number /= 10;

    while (number > 0)
    {
        int currentDigit = number % 10;
        if (Math.Abs(currentDigit - prevDigit) != 1)
        {
            return false;
        }

        prevDigit = currentDigit;
        number /= 10;
    }

    return true;
}