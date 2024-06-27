string str = Console.ReadLine();

int cnt = 0;
for (int i = 0; i < str.Length - 3; i++)
{
    if (str.Substring(i, 4).Equals("DKSH"))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
