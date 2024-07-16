while (true)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    if (a + b == 0) { break; }

    int cnt = 0;
    int add = 0;
    while (a != 0 || b != 0)
    {
        int am = a % 10;
        int bm = b % 10;

        a /= 10;
        b /= 10;

        if (am + bm + add >= 10)
        {
            cnt++;
            add = 1;
        }

        else { add = 0; }
    }

    Console.WriteLine(cnt);
}
