int SelfNumber(int i)
{
    i += 1;
    string str = i.ToString();
    int n = i;
    for (int j = 0; j < str.Length; j++)
    {
        n += int.Parse(str[j].ToString());
    }

    return n;
} 

List<int> results = new List<int>(Enumerable.Range(1, 10000));
for (int i = 0; i < 100000; i++)
{
    results.Remove(SelfNumber(i));
}

Console.WriteLine(string.Join("\n", results));
