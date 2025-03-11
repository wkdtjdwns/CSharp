string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

string[] array = Console.ReadLine().Split(" ");
int[] cards = new int[n];

for (int i = 0; i < n; i++)
{
    cards[i] = int.Parse(array[i]);
}

int result = 0;
for (int i = 0; i < n - 2; i++)
{
    for (int j = i + 1; j < n - 1; j++)
    {
        for (int k = j + 1; k < n; k++)
        {
            int temp = cards[i] + cards[j] + cards[k];
            if (m == temp)
            {
                Console.WriteLine(temp);
                return;
            }

            if (result < temp && temp < m)
            {
                result = temp;
            }
        }
    }
}

Console.WriteLine(result);
