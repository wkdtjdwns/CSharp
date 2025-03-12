using System.Text;

int n = int.Parse(Console.ReadLine());
n = 4 * n - 3;
char[,] board = new char[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        board[i, j] = ' ';
    }
}

Star(0, n);

StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sb.Append(board[i, j]);
    }

    sb.AppendLine();
}

Console.WriteLine(sb);

void Star(int start, int end)
{
    if (end <= start) { return; }

    for (int i = start; i < end; i++)
    {
        board[start, i] = '*';
        board[end - 1, i] = '*';
        board[i, start] = '*';
        board[i, end - 1] = '*';
    }

    Star(start + 2, end - 2);
}
