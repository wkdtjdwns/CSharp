int n = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split(" ");
int cnt = n;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(nums[i]);
    if (num == 1)
    {
        cnt--;
        continue;
    }

    for (int j = 2; j < num; j++)
    {
        if (num % j == 0)
        {
            cnt--;
            break;
        }
    }
}

Console.WriteLine(cnt);
