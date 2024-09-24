int n = int.Parse(Console.ReadLine());
int f = int.Parse(Console.ReadLine());
int result = f - n / 100 * 100 % f;
if (result == f)
{
    result = 0;
}

Console.WriteLine(result.ToString("00"));
