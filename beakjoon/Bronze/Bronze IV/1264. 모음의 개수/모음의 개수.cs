char[] moeum = { 'a', 'e', 'i', 'o', 'u' };

while (true)
{
    int cnt = 0;
    string str = Console.ReadLine().ToLower();
    if (str.Equals("#"))
    {
        break;
    }

    for (int i = 0; i < str.Length; i++)
    {
        foreach (char c in moeum)
        {
            if (str[i] == c)
            {
                cnt++;
            }
        }
    }

    Console.WriteLine(cnt);
}
