int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
int cnt = 0;
for (int i = 0; i < n; i++)
{
    int c = str.IndexOf("pPAp", i);
    if (c == -1)
    {
        break;
    }

    cnt++;
    i = c + 3;
}

Console.WriteLine(cnt);
