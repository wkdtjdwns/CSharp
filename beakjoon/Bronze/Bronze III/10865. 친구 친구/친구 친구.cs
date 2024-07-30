using System.Text;

StringBuilder sb = new StringBuilder();
string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
int[] cnt = new int[n + 1];

for (int i = 0; i < m; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    cnt[int.Parse(ab[0])]++;
    cnt[int.Parse(ab[1])]++;
}

for (int i = 1; i <= n; i++)
{
    sb.Append(cnt[i]).Append("\n");
}

Console.WriteLine(sb);
