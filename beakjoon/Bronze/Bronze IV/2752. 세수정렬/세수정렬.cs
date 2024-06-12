string[] input = Console.ReadLine().Split(" ");
int[] nums = new int[3];

for (int i = 0; i < 3; i++)
{
    nums[i] = int.Parse(input[i]);
}

Array.Sort(nums);
foreach (int num in nums)
{
    Console.Write(num + " ");
}
