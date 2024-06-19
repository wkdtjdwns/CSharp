using System.Text;

StringBuilder answer = new StringBuilder();

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] ab = Console.ReadLine().Split();

    answer.AppendLine((int.Parse(ab[0]) + int.Parse(ab[1])).ToString());
}

Console.WriteLine(answer.ToString());
