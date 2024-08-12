string[,] rgb = new string[10, 10];
for (int i = 0; i < 10; i++)
{
    string[] line = Console.ReadLine().Split(" ");
    for (int j = 0; j < 10; j++)
    {
        rgb[i, j] = line[j];
    }
}

for (int i = 0; i < 10; i++)
{
    bool isSame = true;
    string first = rgb[i, 0];
    for (int j = 1; j < 10; j++)
    {
        if (rgb[i, j] != first)
        {
            isSame = false;
            break;
        }
    }

    if (isSame)
    {
        Console.WriteLine(1);
        return;
    }
}

for (int j = 0; j < 10; j++)
{
    bool isSame = true;
    string first = rgb[0, j];
    for (int i = 1; i < 10; i++)
    {
        if (rgb[i, j] != first)
        {
            isSame = false;
            break;
        }
    }

    if (isSame)
    {
        Console.WriteLine(1);
        return;
    }
}

Console.WriteLine(0);
