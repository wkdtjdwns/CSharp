int n = int.Parse(Console.ReadLine());
char[,] board = new char[101, 101];
int horizontal = 0;
int vertical = 0;

for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        board[i, j] = str[j];
    }
}

for (int i = 0; i < n; i++)
{
    int checkH = 0;
    int checkV = 0;
    for (int j = 0; j < n; j++)
    {
        if (board[i, j] == '.')
        {
            checkH++;
        }

        if (board[i, j] == 'X' || j == n - 1)
        {
            if (checkH >= 2)
            {
                horizontal++;
            }

            checkH = 0;
        }

        if (board[j, i] == '.')
        {
            checkV++;
        }

        if (board[j, i] == 'X' || j == n - 1)
        {
            if (checkV >= 2)
            {
                vertical++;
            }

            checkV = 0;
        }
    }
}

Console.WriteLine($"{horizontal} {vertical}");
