int x = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int total = 0;
for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    total += (a * b);
}

if (total == x )
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}
