Dictionary<string, string> dic = new Dictionary<string, string>();
while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0) break;

    string[] str = new string[n];
    for (int i = 0; i < n; i++)
    {
        str[i] = Console.ReadLine();
    }

    for (int i = 0; i < n; i++)
    {
        string temp = str[i].ToLower();
        dic[temp] = str[i];
        str[i] = str[i].ToLower();
    }

    Array.Sort(str);
    Console.WriteLine(dic[str[0]]);
}
