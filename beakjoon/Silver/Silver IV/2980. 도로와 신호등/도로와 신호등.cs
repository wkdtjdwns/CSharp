string[] nl = Console.ReadLine().Split(" ");
int n = int.Parse(nl[0]);
int l = int.Parse(nl[1]);
int position = 0;
int time = 0;
for (int i = 0; i < n; i++)
{
    string[] drg = Console.ReadLine().Split(" ");
    int d = int.Parse(drg[0]);
    int r = int.Parse(drg[1]);
    int g = int.Parse(drg[2]);

    time += d - position;
    position = d;

    int gap = time % (r + g);
    if (gap < r)
    {
        time += r - gap;
    }
}

time += l - position;
Console.WriteLine(time);
