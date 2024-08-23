string str = Console.ReadLine();
int n = 0;
foreach (char c in str)
{
    if (c != str[0])
    {
        break;
    }

    n++;
}

Console.WriteLine(n);
