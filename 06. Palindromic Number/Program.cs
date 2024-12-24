using System.Numerics;

string num = Console.ReadLine()!;


Permutation(num.ToString());

if (Polindrom.BiggestPolindrom == 0)
{
    Console.WriteLine("No palindromic number available.");
}
else
{
    Console.WriteLine(Polindrom.BiggestPolindrom);
}


void Permutation(string rest, string prefix = "")
{
    if (string.IsNullOrEmpty(rest))
    {
        GetBiggestPolindrom(prefix);
    }

    // Each letter has a chance to be permutated
    for (int i = 0; i < rest.Length; i++)
    {
        char restChar = rest[i];
        Permutation(rest.Remove(i, 1), prefix + rest[i]);
    }
}

void GetBiggestPolindrom(string num)
{
    if (num == new string(num.ToCharArray().Reverse().ToArray()))
    {
        BigInteger bigInteger = BigInteger.Parse(num);
        if (bigInteger > Polindrom.BiggestPolindrom)
        {
            Polindrom.BiggestPolindrom = bigInteger;
        }
    }
}

static class Polindrom
{
    public static BigInteger BiggestPolindrom = new();
}