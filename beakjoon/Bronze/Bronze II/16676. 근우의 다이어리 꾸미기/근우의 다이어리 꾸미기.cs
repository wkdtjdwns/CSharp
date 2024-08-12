int n = int.Parse(Console.ReadLine());
long card = 1;

if (n <= 10)
{
    Console.WriteLine(1);
}

else
{
    while (n >= card)
    {
        string str = card.ToString() + "1";
        card = long.Parse(str);
    }

    Console.WriteLine((card / 10).ToString().Length);
}
