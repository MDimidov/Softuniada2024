int[] nums = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .OrderByDescending(x => x)
    .ToArray();


Console.WriteLine(nums[0]);