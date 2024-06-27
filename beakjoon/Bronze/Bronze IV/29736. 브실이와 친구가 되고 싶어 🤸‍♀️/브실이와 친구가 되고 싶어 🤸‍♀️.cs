string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);

string[] kx = Console.ReadLine().Split(" ");
int k = int.Parse(kx[0]);
int x = int.Parse(kx[1]);

int result = 0;
for (int i = a; i <= b; i++)
{
    if (Math.Abs(k - i) <= x)
    {
        result++;
    }
}

if (result > 0)
{
    Console.WriteLine(result);
}

else
{
    Console.WriteLine("IMPOSSIBLE");
}
