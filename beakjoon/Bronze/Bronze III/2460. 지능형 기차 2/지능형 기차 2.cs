int result = 0;
int now = 0;

for (int i = 0; i < 10; i++)
{
    string[] nm = Console.ReadLine().Split(" ");

    now = now - int.Parse(nm[0]) + int.Parse(nm[1]);
    result = Math.Max(result, now);
}

Console.WriteLine(result);
