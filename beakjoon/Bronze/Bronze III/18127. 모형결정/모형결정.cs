string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
long b = long.Parse(ab[1]);

long result = 0;
long num = 1;
while (b-- > -1)
{
    result += num;
    num += (a - 2);
}

Console.WriteLine(result);
