string[] nt = Console.ReadLine().Split(" ");
int n = int.Parse(nt[0]);
int t = int.Parse(nt[1]);

string[] nums = Console.ReadLine().Split(" ");
int cnt = 0;
for (int i = 0; i < n; i++)
{
    int time = int.Parse(nums[i]);
    if (t - time < 0) { break; }

    t -= time;
    cnt++;
}

Console.WriteLine(cnt);
