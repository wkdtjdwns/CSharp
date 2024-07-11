int n = int.Parse(Console.ReadLine());
int x = 2;
for (int i = 0; i < n; i++)
{
    x += (x - 1);
}

Console.WriteLine(x * x);
