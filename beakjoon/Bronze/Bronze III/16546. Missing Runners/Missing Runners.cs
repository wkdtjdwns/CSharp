int n = int.Parse(Console.ReadLine());
int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int result = 0;
for (int i = 0; i < n - 1; i++)
{
    result += (i + 1);
    result -= nums[i];
}

Console.WriteLine(result + n);
