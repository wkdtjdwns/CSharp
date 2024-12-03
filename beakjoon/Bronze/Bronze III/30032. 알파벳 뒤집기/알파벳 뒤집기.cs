string[] nd = Console.ReadLine().Split(" ");
int n = int.Parse(nd[0]);
int d = int.Parse(nd[1]);

for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    foreach (char c in str)
    {
        if (d == 1)
        {
            if (c == 'd')
            {
                Console.Write('q');
            }

            else if (c == 'b')
            {
                Console.Write('p');
            }

            else if (c == 'q')
            {
                Console.Write('d');
            }

            else
            {
                Console.Write('b');
            }
        }

        else
        {
            if (c == 'd')
            {
                Console.Write('b');
            }

            else if (c == 'b')
            {
                Console.Write('d');
            }

            else if (c == 'q')
            {
                Console.Write('p');
            }

            else
            {
                Console.Write('q');
            }
        }
    }

    Console.WriteLine();
}
