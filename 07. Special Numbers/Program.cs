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




//////Method 2\\\\\\
/////
//using System.Text;

//int n = int.Parse(Console.ReadLine()!);
//int m = int.Parse(Console.ReadLine()!);

//List<int> list = new();

//for (int i = n; i <= m; i++)
//{
//    GetSpecialNum(i);
//}

//Console.WriteLine(string.Join(Environment.NewLine, list));

//void GetSpecialNum(int n)
//{
//    StringBuilder num = new(n.ToString());
//    bool isTrue = true;
//    for (int i = 1; i < num.Length; i++)
//    {
//        int a = (int)num[i];
//        int b = (int)num[i - 1];
//        int result = Math.Abs(a - b);
//        if (result != 1)
//        {
//            isTrue = false;
//            break;
//        }
//    }

//    if (isTrue)
//    {
//        list.Add(n);
//    }
//}