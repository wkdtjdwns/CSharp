string[] sn = Console.ReadLine().Split(" ");
string str = sn[0].ToLower() + " ";
int n = int.Parse(sn[1]);
bool[] alphabet = new bool[26];
char c = str[0];
int cnt = 1;
foreach (char ch in str)
{
    if (ch == c)
    {
        cnt++;
    }

    else
    {
        if (!alphabet[c - 'a'])
        {
            Console.Write(cnt >= n ? 1 : 0);
            alphabet[c - 'a'] = true;
        }

        c = ch;
        cnt = 1;
    }
}
