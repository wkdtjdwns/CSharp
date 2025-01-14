int n = int.Parse(Console.ReadLine());
string[] gist = { "G...", ".I.T", "..S." };
foreach (string str in gist)
{
    string temp = "";
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < n; j++)
        {
            temp += str[i];
        }
    }

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(temp);
    }
}
