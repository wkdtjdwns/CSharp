int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    char[] m = Console.ReadLine().ToCharArray();
    int[] alphabet = new int[26];
    bool check = true;

    for (int j = 0; j < m.Length; j++)
    {
        int gap = m[j] - 65;
        alphabet[gap]++;
        if (alphabet[gap] == 3)
        {
            if (j + 1 >= m.Length)
            {
                check = false;
                break;
            }

            if (m[j] == m[j + 1])
            {
                alphabet[gap] = 0;
                j++;
            }

            else
            {
                check = false;
                break;
            }
        }
    }

    if (check)
    {
        Console.WriteLine("OK");
    }

    else
    {
        Console.WriteLine("FAKE");
    }
}
