using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n * 2; i++)
{
    for (int j = 0; j < n; j++)
    {
        sb.Append("@");
    }

    for (int j = 0; j < n * 3; j++)
    {
        sb.Append(" ");
    }

    for (int j = 0; j < n; j++)
    {
        sb.Append("@");
    }

    sb.AppendLine();
}

for (int i = 0;i < n; i++)
{
    for (int j = 0; j < n * 5; j++)
    {
        sb.Append("@");
    }

    sb.AppendLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sb.Append("@");
    }

    for (int j = 0; j < n * 3; j++)
    {
        sb.Append(" ");
    }

    for (int j = 0; j < n; j++)
    {
        sb.Append("@");
    }

    sb.AppendLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n * 5; j++)
    {
        sb.Append("@");
    }

    sb.AppendLine();
}

Console.WriteLine(sb);
