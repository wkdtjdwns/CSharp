int StripesCnt(string str)
{
    int result = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == '1')
        {
            result++;
        }
    }

    return result;
}

string Remove(string str)
{
    char c = str[0];
    string result = c.ToString();

    for (int i = 1; i < str.Length; i++)
    {
        if (c != str[i])
        {
            result += str[i];
            c = str[i];
        }
    }

    return result;
}

string[] nl = Console.ReadLine().Split(" ");
int n = int.Parse(nl[0]);
int l = int.Parse(nl[1]);

int stripes = 0;
int horseCnt = 0;

for (int i = 0; i < n; i++)
{
    string remove = Remove(Console.ReadLine());
    int cnt = StripesCnt(remove);

    if (cnt > stripes)
    {
        stripes = cnt;
        horseCnt = 1;
    }

    else if (cnt == stripes)
    {
        horseCnt++;
    }
}

Console.WriteLine(stripes + " " + horseCnt);
