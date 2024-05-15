int[] nums = new int[3];

for (int i = 0; i < 3; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
}

Array.Sort(nums);
Console.WriteLine(nums[1]);
