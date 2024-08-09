using System.Text;

StringBuilder sb = new StringBuilder();
int q = int.Parse(Console.ReadLine());
string[] array = new string[32];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Pow(2, i).ToString();
}

for (int i = 0; i < q; i++)
{
    string a = Console.ReadLine();

    if (array.Contains(a))
    {
        sb.AppendLine("1");
    }

    else
    {
        sb.AppendLine("0");
    }
}

Console.WriteLine(sb);
