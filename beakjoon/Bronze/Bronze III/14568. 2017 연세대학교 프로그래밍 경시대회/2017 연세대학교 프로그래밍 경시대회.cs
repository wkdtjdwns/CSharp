int n = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 2; i < n - 1; i += 2)
{
    result += (n - i - 2) / 2;
}

Console.WriteLine(result);
