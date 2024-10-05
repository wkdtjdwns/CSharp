while (true)
{
    string str = Console.ReadLine();
    if (str.Equals("#"))
    {
        break;
    }

    int cnt = 0;
    for (int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] == '1')
        {
            cnt++;
        }
    }

    char result = '1';
    if ((cnt % 2 == 0 && str[str.Length - 1] == 'e') || (cnt % 2 == 1 && str[str.Length - 1] == 'o'))
    {
        result = '0';
    }


    for (int i = 0; i < str.Length - 1; i++)
    {
        Console.Write(str[i]);
    }

    Console.WriteLine(result);
}
