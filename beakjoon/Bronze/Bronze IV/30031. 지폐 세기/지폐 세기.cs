int n = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < n; i++)
{
    string[] wh = Console.ReadLine().Split(" ");
    int width = int.Parse(wh[0]);

    if (width == 136) result += 1000;
    else if (width == 142) result += 5000;
    else if (width == 148) result += 10000;
    else result += 50000;
}

Console.WriteLine(result);
