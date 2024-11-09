using System.Text;

string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
Dictionary<string, string> pokemons = new Dictionary<string, string>();
StringBuilder sb = new StringBuilder();

for (int i = 1; i <= n; i++)
{
    string name = Console.ReadLine();
    pokemons.Add(name, i.ToString());
}

List<string> keys = new List<string>(pokemons.Keys);
for (int i = 0; i < m; i++)
{
    string s = Console.ReadLine();
    if (char.IsDigit(s[0]))
    {
        string key = keys[int.Parse(s) - 1];
        sb.AppendLine(key);
    }

    else
    {
        sb.AppendLine(pokemons[s]);
    }
}

Console.WriteLine(sb.ToString());
