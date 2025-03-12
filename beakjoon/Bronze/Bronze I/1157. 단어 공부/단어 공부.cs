string str = Console.ReadLine().ToLower();
int[] alphabets = new int[26];

foreach (char c in str)
{
    alphabets[c - 'a']++;
}

int max = 0;
int maxIndex = -1;
for (int i = 0; i < 26; i++)
{
    if (alphabets[i] >= max)
    {
        max = alphabets[i];
        maxIndex = i;
    }
}

bool check = false;
for (int i = 0; i < 26; i++)
{
    if (i == maxIndex) { continue; }
    if (alphabets[i] == max) { check = true; }
}

if (check)
{
    Console.WriteLine("?");
}

else
{
    Console.WriteLine((char)('A' + maxIndex));
}
