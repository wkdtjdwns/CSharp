int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string result = Console.ReadLine();
    int score = 0;
    int oCnt = 0;

    foreach (char c in result)
    {
        if (c == 'O')
        {
            score += 1 + oCnt;
            oCnt++;
        }

        else
        {
            oCnt = 0;
        }
    }

    Console.WriteLine(score);
}
