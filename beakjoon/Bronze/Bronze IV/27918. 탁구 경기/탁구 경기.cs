int n = int.Parse(Console.ReadLine());
int x = 0;
int y = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();

    if (str.Equals("D"))
    {
        x++;
    }

    else
    {
        y++;
    }

    if (Math.Abs(x - y) >= 2)
    {
        break;
    }
}

Console.WriteLine(x + ":" + y);
