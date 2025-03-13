char[,] strs = new char[5, 15];
for (int i = 0; i < 5; i++)
{
    string str = Console.ReadLine();
    for (int k = 0; k < str.Length; k++)
    {
        strs[i, k] = str[k];
    }
}

for (int i = 0; i < 15; i++)
{
    for (int k = 0; k < 5; k++)
    {
        if (strs[k, i] == '\0') { continue; }

        Console.Write(strs[k, i]);
    }
}
