int n = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    result += b % a;
}

Console.WriteLine(result);
