string[] nums = Console.ReadLine().Split(" ");
int cnt = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (int.Parse(nums[i]) > 0)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
