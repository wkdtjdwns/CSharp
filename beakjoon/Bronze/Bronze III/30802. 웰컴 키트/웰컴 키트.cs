int n = int.Parse(Console.ReadLine());
int[] size = new int[6];
string[] s = Console.ReadLine().Split(" ");
for (int i = 0; i < 6; i++)
{
    size[i] = int.Parse(s[i]);
}

string[] tp = Console.ReadLine().Split(" ");
int t = int.Parse(tp[0]);
int p = int.Parse(tp[1]);
int cnt = 0;
for (int i = 0; i < 6; i++)
{
    cnt += size[i] / t;
    cnt = size[i] % t > 0 ? cnt + 1 : cnt;
}

Console.WriteLine(cnt);
Console.WriteLine(n / p + " " + n % p);
