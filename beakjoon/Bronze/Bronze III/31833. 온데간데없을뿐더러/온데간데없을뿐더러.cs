int n = int.Parse(Console.ReadLine());
string resultA = "";
string resultB = "";

string[] input = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    long num = int.Parse(input[i]);
    resultA += num;
}

input = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    long num = int.Parse(input[i]);
    resultB += num;
}

long a = long.Parse(resultA);
long b = long.Parse(resultB);
if (a > b)
{
    Console.WriteLine(b);
}

else
{
    Console.WriteLine(a);
}
