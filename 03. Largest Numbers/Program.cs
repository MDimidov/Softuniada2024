int[] intsArr = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .OrderByDescending(x => x)
    .ToArray();

int arrLength = int.Parse(Console.ReadLine()!);

int[] result = intsArr
    .Take(arrLength)
    .OrderBy(x => x)
    .ToArray();

Console.WriteLine(string.Join(Environment.NewLine, result));