int n = int.Parse(Console.ReadLine());
int a = 100;
int b = 100;
for (int i = 0; i < n; i++)
{
    string[] xy = Console.ReadLine().Split(" ");
    int x = int.Parse(xy[0]);
    int y = int.Parse(xy[1]);

    if (x > y) { b -= x; }
    else if (y > x) { a -= y; }
}

Console.WriteLine(a);
Console.WriteLine(b);
