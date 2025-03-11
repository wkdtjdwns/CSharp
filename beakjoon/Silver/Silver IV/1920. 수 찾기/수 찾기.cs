using System.Text;

int n = int.Parse(Console.ReadLine());
string[] nsInput = Console.ReadLine().Split(" ");
HashSet<int> nsSet = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    nsSet.Add(int.Parse(nsInput[i]));
}

int m = int.Parse(Console.ReadLine());
string[] msInput = Console.ReadLine().Split(" ");
StringBuilder sb = new StringBuilder();
foreach (string str in msInput)
{
    if (nsSet.Contains(int.Parse(str)))
    {
        sb.AppendLine("1");
    }

    else
    {
        sb.AppendLine("0");
    }
}

Console.WriteLine(sb);
