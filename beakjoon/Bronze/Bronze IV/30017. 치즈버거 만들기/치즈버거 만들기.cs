string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);

int result = 1;
a--;

while (a > 0 && b > 0)
{
    result += 2;
    a--;
    b--;
}

Console.WriteLine(result);
