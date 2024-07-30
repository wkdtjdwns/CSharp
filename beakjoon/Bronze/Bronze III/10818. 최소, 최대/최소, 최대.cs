int n = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split(" ");
int max = int.MinValue;
int min = int.MaxValue;

foreach (string num in nums)
{
    max = Math.Max(max, int.Parse(num));
    min = Math.Min(min, int.Parse(num));
}

Console.WriteLine(min + " " + max);
