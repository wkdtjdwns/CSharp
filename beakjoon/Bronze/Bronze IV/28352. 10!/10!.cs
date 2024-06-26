int n = int.Parse(Console.ReadLine());
long result = 1;
for (int i = 11; i <= n; i++)
{
    result *= i;
}

Console.WriteLine(6 * result);
