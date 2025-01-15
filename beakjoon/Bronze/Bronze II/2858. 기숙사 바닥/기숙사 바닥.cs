string[] rb = Console.ReadLine().Split(" ");
int r = int.Parse(rb[0]);
int b = int.Parse(rb[1]);
int l = 0;
int w = 0;

for (int i = 0; i < 5000; i++)
{
    for (int j = 0; j < 4000; j++)
    {
        if (r + b == i * j)
        {
            if (r == (i * 2) + (j - 2) * 2)
            {
                l = i;
                w = j;
                break;
            }

            else if (r == (j * 2) + (i - 2) * 2)
            {
                l = j;
                w = i;
                break;
            }
        }
    }
}

Console.WriteLine(l + " " + w);
