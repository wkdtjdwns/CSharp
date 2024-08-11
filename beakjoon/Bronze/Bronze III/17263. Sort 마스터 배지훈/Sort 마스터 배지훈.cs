int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(" ");
int[] nums = new int[n];
for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(input[i]);
}

Array.Sort(nums);
Console.WriteLine(nums[n - 1]);
