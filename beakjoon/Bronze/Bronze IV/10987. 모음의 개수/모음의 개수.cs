string str = Console.ReadLine();
int cnt = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'a' || str[i] == 'e' ||
        str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
