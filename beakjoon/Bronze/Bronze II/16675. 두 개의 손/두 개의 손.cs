string whoWin(string ms, string tk, Dictionary<string, string> win)
{
    string msWin = win[ms];
    string tkWin = win[tk];

    if (msWin.Equals(tk))
    {
        return "MS";
    }

    if (tkWin.Equals(ms))
    {
        return "TK";
    }

    return "DRAW";
}

Dictionary<string, string> win = new Dictionary<string, string>
{
    {"P", "R"},
    {"R", "S"},
    {"S", "P"}
};

string[] input = Console.ReadLine().Split(" ");
string ms1 = input[0];
string ms2 = input[1];
string tk1 = input[2];
string tk2 = input[3];

string ms1Vstk1 = whoWin(ms1, tk1, win);
string ms1Vstk2 = whoWin(ms1, tk2, win);
string ms2Vstk1 = whoWin(ms2, tk1, win);
string ms2Vstk2 = whoWin(ms2, tk2, win);

if (ms1.Equals(ms2) && tk1.Equals(tk2) && ms1.Equals(tk1))
{
    Console.WriteLine("?");
    return;
}

if (ms1.Equals(ms2))
{
    if (ms1Vstk1.Equals("TK") || ms1Vstk2.Equals("TK"))
    {
        Console.WriteLine("TK");
    }

    else if (ms1Vstk1.Equals("DRAW") || ms1Vstk2.Equals("DRAW"))
    {
        Console.WriteLine("?");
    }

    else
    {
        Console.WriteLine("MS");
    }

    return;
}

if (tk1.Equals(tk2))
{
    if (ms1Vstk1.Equals("MS") || ms2Vstk1.Equals("MS"))
    {
        Console.WriteLine("MS");
    }

    else if (ms1Vstk1.Equals("DRAW") || ms2Vstk1.Equals("DRAW"))
    {
        Console.WriteLine("?");
    }

    else
    {
        Console.WriteLine("TK");
    }

    return;
}

Console.WriteLine("?");
