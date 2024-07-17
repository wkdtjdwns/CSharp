using System.Text;

StringBuilder sb = new StringBuilder();
for (int a = 2; a <= 100; a++)
{
    for (int b = 2; b <= a; b++)
    {
        for (int c = b; c <= a; c++)
        {
            for (int d = c; d <= a; d++)
            {
                if (a * a * a == b * b * b + c * c * c + d * d * d)
                {
                    sb.Append("Cube = ").Append(a).Append(", Triple = (").Append(b);
                    sb.Append(",").Append(c).Append(",").Append(d).Append(")").Append("\n");
                }
            }
        }
    }
}

Console.WriteLine(sb);
