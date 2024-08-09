string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
long m = long.Parse(nm[1]);

long result = 1;
string[] results = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    result = (result * (long.Parse(results[i]) % m)) % m;
}

Console.WriteLine(result);
