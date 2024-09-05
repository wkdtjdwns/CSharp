string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);
for (int i = 0; i < n - 1; i++)
{
    k /= 2;
}

Console.WriteLine(k);
