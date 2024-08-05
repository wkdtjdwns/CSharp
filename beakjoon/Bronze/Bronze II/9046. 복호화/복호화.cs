int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    int[] results = new int[26];
    for (int j = 0; j < str.Length; j++)
    {
        if (str[j] >= 'a' && str[j] <= 'z')
        {
            results[str[j] - 'a']++;
        }
    }

    int max = 0;
    foreach (int r in results)
    {
        max = Math.Max(max, r);
    }

    int cnt = 0;
    int result = 0;
    for (int j = 0; j < 26; j++)
    {
        if (max == results[j])
        {
            cnt++;
            result = j;
        }
    }

    Console.WriteLine(cnt == 1 ? (char)(result + 'a') : "?");
}
