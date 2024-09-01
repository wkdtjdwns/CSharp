int t = int.Parse(Console.ReadLine());
Console.ReadLine();

for (int i = 0; i < t; i++)
{
    if (i > 0)
    {
        Console.ReadLine();
    }

    string[] rc = Console.ReadLine().Split(' ');
    int r = int.Parse(rc[0]);
    int c = int.Parse(rc[1]);

    char[][] board = new char[r][];
    for (int j = 0; j < r; j++)
    {
        board[j] = Console.ReadLine().ToCharArray();
    }

    int cnt = 0;
    for (int j = 0; j < r; j++)
    {
        for (int k = 0; k <= c - 3; k++)
        {
            if (board[j][k] == '>' && board[j][k + 1] == 'o' && board[j][k + 2] == '<')
            {
                cnt++;
            }
        }
    }

    for (int j = 0; j < c; j++)
    {
        for (int k = 0; k <= r - 3; k++)
        {
            if (board[k][j] == 'v' && board[k + 1][j] == 'o' && board[k + 2][j] == '^')
            {
                cnt++;
            }
        }
    }
    Console.WriteLine(cnt);
}
