int n = int.Parse(Console.ReadLine());
string[] a = Console.ReadLine().Split(" ");
string[] b = Console.ReadLine().Split(" ");

int cnt = 0;
for (int i = 0; i < n; i++)
{
    if (int.Parse(a[i]) <= int.Parse(b[i])) cnt++;
}

Console.WriteLine(cnt);
