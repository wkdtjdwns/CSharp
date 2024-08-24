int a = 0;
int b = 0;
bool foundA = false;
bool foundB = false;
for (int i = 1; i <= 9; i++)
{
    if (!foundA)
    {
        Console.WriteLine("? A " + i);
        Console.Out.Flush();
        int response = int.Parse(Console.ReadLine().Trim());

        if (response == 1)
        {
            a = i;
            foundA = true;
        }
    }

    if (!foundB)
    {
        Console.WriteLine("? B " + i);
        Console.Out.Flush();
        int response = int.Parse(Console.ReadLine().Trim());

        if (response == 1)
        {
            b = i;
            foundB = true;
        }
    }

    if (foundA && foundB)
    {
        break;
    }
}

Console.WriteLine("! " + (a + b));
Console.Out.Flush();
