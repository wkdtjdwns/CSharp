using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] hwn = Console.ReadLine().Split(" ");
    int h = int.Parse(hwn[0]);
    int n = int.Parse(hwn[2]);

    if (n % h == 0)
    {
        sb.Append((h * 100) + (n / h)).Append("\n");
    }

    else
    {
        sb.Append(((n % h) * 100) + ((n / h) + 1)).Append("\n");
    }
}

Console.WriteLine(sb);
