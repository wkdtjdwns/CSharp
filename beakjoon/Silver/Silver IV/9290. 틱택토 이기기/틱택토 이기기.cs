int T = int.Parse(Console.ReadLine());
for (int t = 1; t <= T; t++)
{
    char[][] board = new char[3][];
    for (int i = 0; i < 3; i++)
    {
        board[i] = Console.ReadLine().ToCharArray();
    }

    char p = Console.ReadLine()[0];
    bool check = false;

    for (int i = 0; i < 3 && !check; i++)
    {
        for (int j = 0; j < 3 && !check; j++)
        {
            if (board[i][j] == '-')
            {
                board[i][j] = p;

                if ((board[0][0] == p && board[0][1] == p && board[0][2] == p) ||
                    (board[1][0] == p && board[1][1] == p && board[1][2] == p) ||
                    (board[2][0] == p && board[2][1] == p && board[2][2] == p) ||
                    (board[0][0] == p && board[1][0] == p && board[2][0] == p) ||
                    (board[0][1] == p && board[1][1] == p && board[2][1] == p) ||
                    (board[0][2] == p && board[1][2] == p && board[2][2] == p) ||
                    (board[0][0] == p && board[1][1] == p && board[2][2] == p) ||
                    (board[0][2] == p && board[1][1] == p && board[2][0] == p))
                {
                    Console.WriteLine($"Case {t}:");
                    for (int x = 0; x < 3; x++)
                    {
                        Console.WriteLine(new string(board[x]));
                    }

                    check = true;
                }

                board[i][j] = '-';
            }
        }
    }
}
