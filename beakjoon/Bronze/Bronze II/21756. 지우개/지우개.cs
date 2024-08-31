int n = int.Parse(Console.ReadLine());
int result = 1;
while (result * 2 <= n)
{
    result *= 2;
}

Console.WriteLine(result);
