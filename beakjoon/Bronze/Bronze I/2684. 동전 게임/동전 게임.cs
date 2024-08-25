int p = int.Parse(Console.ReadLine());
int[] results = new int[8];
for (int i = 0; i < p; i++)
{
    string str = Console.ReadLine();
    for (int j = 0; j < 8;  j++)
    {
        results[j] = 0;
    }

    for (int j = 0; j < 38; j++)
    {
        if (str[j] == 'H')
        {
            if (str[j + 1] == 'H')
            {
                if (str[j + 2] == 'H')
                {
                    results[7]++;
                }

                else
                {
                    results[6]++;
                }
            }

            else
            {
                if (str[j + 2] == 'H')
                {
                    results[5]++;
                }

                else
                {
                    results[4]++;
                }
            }
        }

        else
        {
            if (str[j + 1] == 'H')
            {
                if (str[j + 2] == 'H')
                {
                    results[3]++;
                }

                else
                {
                    results[2]++;
                }
            }

            else
            {
                if (str[j + 2] == 'H')
                {
                    results[1]++;
                }

                else
                {
                    results[0]++;
                }
            }
        }
    }

    foreach (int coin in results)
    {
        Console.Write(coin + " ");
    }

    Console.WriteLine();
}
