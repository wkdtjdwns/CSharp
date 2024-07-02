while (true)
{
    int n = int.Parse(Console.ReadLine());
    int sum = 0;

    if (n == 0) { return; }

    while (true)
    {
        if (n % 10 == 1) { sum += 2; }
        else if (n % 10 == 0) { sum += 4; }
        else { sum += 3; }

        if (n < 10) { break; }

        n /= 10;
        sum += 1;
    }

    Console.WriteLine(sum + 2);
}
