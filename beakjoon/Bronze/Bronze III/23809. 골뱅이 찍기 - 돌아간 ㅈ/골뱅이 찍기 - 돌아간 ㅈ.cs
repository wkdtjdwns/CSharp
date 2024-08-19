using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            sb.Append("@");
        }

        for (int k = 0; k < n * (3 - i); k++)
        {
            sb.Append(" ");
        }

        for (int k = 0; k < n; k++)
        {
            sb.Append("@");
        }

        sb.AppendLine();
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n * 3; j++)
    {
        sb.Append("@");
    }

    sb.AppendLine();
}

for (int i = 1; i >= 0; i--)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            sb.Append("@");
        }

        for (int k = 0; k < n * (3 - i); k++)
        {
            sb.Append(" ");
        }

        for (int k = 0; k < n; k++)
        {
            sb.Append("@");
        }

        sb.AppendLine();
    }
}

Console.WriteLine(sb);
