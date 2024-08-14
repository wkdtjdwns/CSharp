string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);

int root = (int)Math.Sqrt(a * a - b);
int result1 = (-1 * a) - root;
int result2 = (-1 * a) + root;

if (result1 == result2)
{
    Console.WriteLine(result1);
}

else
{
    Console.WriteLine(result1 + " " + result2);
}
