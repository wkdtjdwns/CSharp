string str = Console.ReadLine();
int[] alphabets = new int[26];
for (int i = 0; i < 26; i++)
{
    alphabets[i] = -1;
}

for (int i = 0; i < str.Length; i++)
{
    for (int j = 0; j < 26; j++)
    {
        if (str[i] == (char)(97 + j) && alphabets[j] == -1)
        {
            alphabets[j] = i;
        }
    }
}

foreach (int alpha in alphabets)
{
    Console.Write(alpha + " ");
}
