int n = int.Parse(Console.ReadLine());
string[] club = { "PROBRAIN", "GROW", "ARGOS", "ADMIN", "ANT", "MOTION", "SPG", "COMON", "ALMIGHTY" };
int max = 0;
int group = 0;

for (int i = 0; i < 9; i++)
{
    string[] nums = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        int num = int.Parse(nums[j]);
        if (max < num)
        {
            max = num;
            group = i;
        }
    }
}

Console.WriteLine(club[group]);
