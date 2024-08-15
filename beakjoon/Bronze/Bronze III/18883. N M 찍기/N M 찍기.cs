using System.Text;

StringBuilder sb = new StringBuilder();
string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
for (int i = 1; i <= n * m; i++)
{
    if (i % m == 0)
    {
        sb.Append(i).Append("\n");
    }

    else
    {
        sb.Append(i).Append(" ");
    }
}

Console.WriteLine(sb);
