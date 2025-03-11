string[] str = Console.ReadLine().Split(" ");
bool isAscending = true;
if (int.Parse(str[0]) > int.Parse(str[1]))
{
    isAscending = false;
}

for (int i = 1; i < 7; i++)
{
    if (isAscending)
    {
        if (int.Parse(str[i]) > int.Parse(str[i + 1]))
        {
            Console.WriteLine("mixed");
            return;
        }
    }

    else
    {
        if (int.Parse(str[i]) < int.Parse(str[i + 1]))
        {
            Console.WriteLine("mixed");
            return;
        }
    }
}

if (isAscending)
{
    Console.WriteLine("ascending");
}

else
{
    Console.WriteLine("descending");
}
