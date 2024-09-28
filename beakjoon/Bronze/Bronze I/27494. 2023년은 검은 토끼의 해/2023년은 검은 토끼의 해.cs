bool Check(string s)
{
    int position = s.IndexOf('2');
    if (position == -1)
    {
        return false;
    }

    s = s.Substring(position + 1);

    position = s.IndexOf('0');
    if (position == -1)
    {
        return false;
    }

    s = s.Substring(position + 1);

    position = s.IndexOf('2');
    if (position == -1)
    {
        return false;
    }

    s = s.Substring(position + 1);

    position = s.IndexOf('3');
    if (position == -1)
    {
        return false;
    }

    return true;
}

int n = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 1; i <= n; i++)
{
    if (Check(i.ToString()))
    {
        result++;
    }
}

Console.WriteLine(result);
