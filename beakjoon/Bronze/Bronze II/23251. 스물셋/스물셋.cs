using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    long n = long.Parse(Console.ReadLine());
    sb.Append(n * 23).Append("\n");
}

Console.WriteLine(sb);
