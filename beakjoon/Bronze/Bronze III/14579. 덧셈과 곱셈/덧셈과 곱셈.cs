string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);
int temp = (a + 1) * a / 2 % 14579;
int result = temp;
for (int i = a + 1; i <= b; i++)
{
    result *= (temp += i);
    result %= 14579;
}

Console.WriteLine(result);
