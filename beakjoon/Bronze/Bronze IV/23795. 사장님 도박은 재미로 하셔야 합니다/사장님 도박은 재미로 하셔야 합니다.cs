int total = 0;
while (true)
{
    int money = int.Parse(Console.ReadLine());

    if (money == -1)
    {
        break;
    }

    total += money;
}

Console.WriteLine(total);
