string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);
int c = int.Parse(Console.ReadLine());

b += c;
a += b / 60;
b %= 60;

if (a >= 24)
{
    a -= 24;
}

Console.WriteLine(a + " " + b);
