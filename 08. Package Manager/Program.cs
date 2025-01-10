int packages = int.Parse(Console.ReadLine()!);
int connections = int.Parse(Console.ReadLine()!);
Dictionary<int, List<int>> dependencies = new();
for (int i = 0; i < connections; i++)
{
    int[] input = Console.ReadLine()!
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (!dependencies.ContainsKey(input[0])) dependencies[input[0]] = new();

    if (input.Length > 1)
    {
        dependencies[input[0]].Add(input[1]);

        if (dependencies.ContainsKey(input[1]) &&
            dependencies[input[1]].Contains(input[0]))
        {
            Console.WriteLine("circular dependency");
            return;
        }
    }
}

dependencies = dependencies
    .OrderBy(x => x.Key)
    .ToDictionary(x => x.Key, y => y.Value
    .OrderBy(x => x)
    .ToList());

List<int> list = new();
foreach (int key in dependencies.Keys)
{
    ShowResult(key, list);
}

list = list.Take(packages).ToList();
Console.WriteLine(string.Join(' ', list));


void ShowResult(int key, List<int> list)
{
    bool isMainKey = true;
    foreach (int k in dependencies
        .Keys
        .Where(x => x != key))
    {
        if (dependencies[k].Contains(key))
        {
            isMainKey = false;
            break;
        }

    }

    if (isMainKey)
    {
        list.Add(key);
        ShowSecondaryKeys(key, list);
    }
}

void ShowSecondaryKeys(int key, List<int> list)
{
    if (dependencies.ContainsKey(key))
    {
        foreach (int key1 in dependencies[key])
        {
            list.Add(key1);

            ShowSecondaryKeys(key1, list);
        }
    }
}