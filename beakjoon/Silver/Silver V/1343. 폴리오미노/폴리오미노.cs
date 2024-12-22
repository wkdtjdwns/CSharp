string board = Console.ReadLine();
char[] result = board.ToCharArray();

int i = 0;
while (i < board.Length)
{
    if (board[i] == 'X')
    {
        int count = 0;

        while (i + count < board.Length && board[i + count] == 'X')
        {
            count++;
        }

        if (count % 2 != 0)
        {
            Console.WriteLine(-1);
            return;
        }

        while (count >= 4)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i++] = 'A';
            }
            count -= 4;
        }

        while (count >= 2)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i++] = 'B';
            }

            count -= 2;
        }
    }

    else
    {
        i++;
    }
}

Console.WriteLine(result);
