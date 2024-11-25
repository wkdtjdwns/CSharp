string[] abc = Console.ReadLine().Split(" ");
long a = long.Parse(abc[0]);
long b = long.Parse(abc[1]);
long c = long.Parse(abc[2]);

string[] xyz = Console.ReadLine().Split(" ");
long x = long.Parse(xyz[0]);
long y = long.Parse(xyz[1]);
long z = long.Parse(xyz[2]);

long result = 0;

for (int i = 0; i < 3; i++)
{
    long chicken = Math.Min(a, x);
    result += chicken;
    a -= chicken;
    x -= chicken;

    long pizza = Math.Min(b, y);
    result += pizza;
    b -= pizza;
    y -= pizza;

    long burger = Math.Min(c, z);
    result += burger;
    c -= burger;
    z -= burger;

    long temp1 = y;
    long temp2 = z;
    y = x / 3;
    z = temp1 / 3;
    x = temp2 / 3;
}

Console.WriteLine(result);
