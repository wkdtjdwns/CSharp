using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder answer = new StringBuilder();

for (int i = n; i > 0; i--)
{
    answer.AppendLine(i.ToString());
}

Console.WriteLine(answer);
