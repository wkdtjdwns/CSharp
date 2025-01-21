string str = Console.ReadLine();
int joi = 0;
int ioi = 0;
for (int i = 0; i < str.Length - 2; i++)
{
    if (str[i] == 'J' && str[i + 1] == 'O' && str[i + 2] == 'I')
    {
        joi++;
    }

    else if (str[i] == 'I' && str[i + 1] == 'O' && str[i + 2] == 'I')
    {
        ioi++;
    }
}

Console.WriteLine(joi);
Console.WriteLine(ioi);
