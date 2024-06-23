int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int min = p;

for (int i = 1; i <= 4; i++)
{
    if (i * 5 > n) break;
    switch (i)
    {
        case 1: min = Math.Min(min, p - 500); break;
        case 2: min = Math.Min(min, (int)(p * 0.9)); break;
        case 3: min = Math.Min(min, p - 2000); break;
        case 4: min = Math.Min(min, (int)(p * 0.75)); break;
    }
}

Console.WriteLine(min < 0 ? 0 : min);
