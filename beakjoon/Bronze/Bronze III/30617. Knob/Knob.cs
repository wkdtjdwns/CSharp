int t = int.Parse(Console.ReadLine());
int a = 0; int b = 0;
int result = 0;
for (int i = 0; i < t; i++)
{
    string[] cd = Console.ReadLine().Split(" ");
    int c = int.Parse(cd[0]);
    int d = int.Parse(cd[1]);
    if (i > 0)
    {
        if (a == c && a != 0)
        {
            result++;
        }

        if (b == d && b != 0)
        {
            result++;
        }
    }

    if (c == d && c != 0)
    {
        result++;
    }

    a = c; b = d;
}

Console.WriteLine(result);
