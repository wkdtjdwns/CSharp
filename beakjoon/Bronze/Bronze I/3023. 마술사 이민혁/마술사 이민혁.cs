string[] rc = Console.ReadLine().Split(" ");
int r = int.Parse(rc[0]);
int c = int.Parse(rc[1]);

char[,] board = new char[r, c];
for (int i = 0; i < r; i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < c; j++)
    {
        board[i, j] = input[j];
    }
}

string[] error = Console.ReadLine().Split(" ");
int a = int.Parse(error[0]) - 1;
int b = int.Parse(error[1]) - 1;

char[,] result = new char[2 * r, 2 * c];
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        result[i, j] = board[i, j];
        result[i, 2 * c - 1 - j] = board[i, j];
        result[2 * r - 1 - i, j] = board[i, j];
        result[2 * r - 1 - i, 2 * c - 1 - j] = board[i, j];
    }
}

if (result[a, b] == '#')
{
    result[a, b] = '.';
}

else
{
    result[a, b] = '#';
}

for (int i = 0; i < 2 * r; i++)
{
    for (int j = 0; j < 2 * c; j++)
    {
        Console.Write(result[i, j]);
    }

    Console.WriteLine();
}
