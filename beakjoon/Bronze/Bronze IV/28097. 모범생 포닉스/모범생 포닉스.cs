int n = int.Parse(Console.ReadLine());
int time = 8 * (n - 1);

string[] times = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    time += int.Parse(times[i]);
}

Console.WriteLine(time / 24 + " " + time % 24);
