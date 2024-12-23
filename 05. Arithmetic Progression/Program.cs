List<int> ints = Console.ReadLine()!
    .Split(' ')
    .Select(int.Parse)
    .OrderBy(x => x)
    .ToList();

int result = 1;

if (ints.Count >= 1)
{
    result += ints.Count;
}

if (ints.Count > 1)
{
    for (int i = 2; i <= ints.Count; i++)
    {
        for (int startIndex = 0; startIndex < ints.Count - (i - 1); startIndex++)
        {
            recursivelyFindProgressions(i, startIndex, ints, 1, 0);
        }
    }
}

Console.WriteLine(result);

void recursivelyFindProgressions(int length, int curIndex, List<int> ints, int curLength, int step)
{
    for (int j = curIndex + 1; j < ints.Count; j++)
    {
        int num = ints[j];
        int lastNum = ints[curIndex];
        if (curLength == 1)
        {
            step = num - lastNum;
        }

        if (step == (num - lastNum))
        {
            if (curLength + 1 == length)
            {
                result++;
            }
            else
            {
                recursivelyFindProgressions(length, j, ints, curLength + 1, step);
            }
        }
    }
}