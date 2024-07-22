int CountChar(string str, char target)
{
    int cnt = 0;
    foreach (char c in str)
    {
        if (c == target) cnt++;
    }

    return cnt;
}

string str = Console.ReadLine();
int colon = CountChar(str, ':');
int underBar = CountChar(str, '_');

Console.WriteLine(str.Length + colon + underBar * 5);
