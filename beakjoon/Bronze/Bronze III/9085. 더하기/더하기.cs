int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    string[] nums = Console.ReadLine().Split(" ");
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum += int.Parse(nums[j]);
    }

    Console.WriteLine(sum);
}
