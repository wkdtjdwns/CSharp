string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
HashSet<string> people = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    people.Add(Console.ReadLine());
}

List<string> results = new List<string>();
for (int i = 0; i < m; i++)
{
    string str = Console.ReadLine();
    if (people.Contains(str))
    {
        results.Add(str);
    }
}

results.Sort();
Console.WriteLine(results.Count);
foreach (string result in results)
{
    Console.WriteLine(result);
}
