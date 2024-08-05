int n = int.Parse(Console.ReadLine());
long result = 0;
for (int i = 0; i < n; i++)
{
    string[] nums = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        result += long.Parse(nums[j]);
    }
}

Console.WriteLine(result);
