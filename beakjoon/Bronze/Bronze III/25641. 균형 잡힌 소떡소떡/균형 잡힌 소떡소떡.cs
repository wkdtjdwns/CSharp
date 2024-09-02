int t = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
int sCnt = 0;
int tCnt = 0;
for (int i = 0; i < t; i++)
{
    if (str[i] == 's')
    {
        sCnt++;
    }

    else
    {
        tCnt++;
    }
}

for (int i = 0; i < t; i++)
{
    if (sCnt == tCnt)
    {
        Console.WriteLine(str.Substring(i));
        break;
    }

    else if (str[i] == 's')
    {
        sCnt--;
    }

    else
    {
        tCnt--;
    }
}
