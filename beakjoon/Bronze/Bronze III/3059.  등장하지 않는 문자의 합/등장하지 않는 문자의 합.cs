int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    String str = Console.ReadLine();
    bool[] alpha = new bool[26];
    for (int j = 0; j < str.Length; j++)
    {
        if (!alpha[str[j] - 'A']) { alpha[str[j] - 'A'] = true; }
    }

    int sum = 0;
    int cnt = 0;
    for (int k = 0; k < alpha.Length; k++)
    {
        if (!alpha[k])
        {
            sum += k;
            cnt++;
        }
    }

    sum += cnt * 65;
    Console.WriteLine(sum);
}
