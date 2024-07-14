int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int sum = 0;
    int min = 100;

    string[] nums = Console.ReadLine().Split(" ");
    for (int j = 0; j < 7; j++)
    {
        int n = int.Parse(nums[j]);
        if (n % 2 == 0)
        {
            sum += n;
            min = Math.Min(min, n);
        }
    }

    Console.WriteLine(sum + " " + min);
}
