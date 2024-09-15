string[] rcw = Console.ReadLine().Split(" ");
int r = int.Parse(rcw[0]);
int c = int.Parse(rcw[1]);
int w = int.Parse(rcw[2]);
int[,] board = new int[r + w + 1, r + w + 1];
board[1, 1] = 1;
for (int i = 2; i <= r + w; i++)
{
    for (int j = 1; j <= i; j++)
    {
        board[i, j] = board[i - 1, j - 1] + board[i - 1, j];
    }
}

int result = 0;
for (int i = 0; i < w; i++)
{
    for (int j = 0; j <= i; j++)
    {
        result += board[r + i, c + j];
    }
}

Console.WriteLine(result);
