string line;
while ((line = Console.ReadLine()) != null)
{
    string[] nmb = line.Split(" ");
    double n = double.Parse(nmb[0]);
    double m = double.Parse(nmb[1]);
    double b = double.Parse(nmb[2]);

    int cnt = 0;
    while (n < b)
    {
        n += n * (m / 100);
        cnt++;
    }

    Console.WriteLine(cnt);
}
