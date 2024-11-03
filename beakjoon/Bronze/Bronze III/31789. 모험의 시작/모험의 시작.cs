int n = int.Parse(Console.ReadLine());
string[] xs = Console.ReadLine().Split(" ");
int x = int.Parse(xs[0]);
int s = int.Parse(xs[1]);
bool check = false;
for (int i = 0; i < n; i++)
{
    string[] cp = Console.ReadLine().Split(" ");
    int c = int.Parse(cp[0]);
    int p = int.Parse(cp[1]);
    if (x >= c && p > s)
    {
        check = true;
    }
}

if (check)
{
    Console.WriteLine("YES");
}

else
{
    Console.WriteLine("NO");
}
