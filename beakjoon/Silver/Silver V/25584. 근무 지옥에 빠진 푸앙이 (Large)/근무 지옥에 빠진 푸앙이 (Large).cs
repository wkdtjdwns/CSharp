int n = int.Parse(Console.ReadLine());
Dictionary<string, int> workTimes = new Dictionary<string, int>();
int[] workHours = { 4, 6, 4, 10 };

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < 4; j++)
    {
        string[] workers = Console.ReadLine().Split(" ");
        foreach (string worker in workers)
        {
            if (worker != "-")
            {
                if (!workTimes.ContainsKey(worker))
                {
                    workTimes[worker] = 0;
                }

                workTimes[worker] += workHours[j];
            }
        }
    }
}

int min = int.MaxValue;
int max = int.MinValue;
foreach (var time in workTimes.Values)
{
    min = Math.Min(min, time);
    max = Math.Max(max, time);
}

if (max - min <= 12)
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}
