bool IsPricked(int start, bool[,] finger)
{
    for (int i = 1; i <= 5; i++)
    {
        if (finger[start, i])
        {
            return false;
        }
    }

    return true;
}

int n = int.Parse(Console.ReadLine());
bool[,] finger = new bool[6, 6];
for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    finger[a, b] = true;
}

if ((finger[1, 3] || finger[3, 1]) &&
    (finger[1, 4] || finger[4, 1]) &&
    (finger[3, 4] || finger[4, 3]) &&
    IsPricked(2, finger) && IsPricked(5, finger))
{
    Console.WriteLine("Wa-pa-pa-pa-pa-pa-pow!");
}

else
{
    Console.WriteLine("Woof-meow-tweet-squeek");
}
