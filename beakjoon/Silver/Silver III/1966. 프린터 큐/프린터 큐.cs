int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] nm = Console.ReadLine().Split(" ");
    int n = int.Parse(nm[0]);
    int m = int.Parse(nm[1]);
    int[] s = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    int result = 0;

    int max = s.Max();
    int maxIndex = Array.IndexOf(s, max);
    int index = maxIndex;

    if (n == 1)
    {
        Console.WriteLine(1);
    }

    else
    {
        while (true)
        {
            if (max == s[m] && index == m)
            {
                result++;
                break;
            }

            else if (index < s.Length)
            {
                if (s[index] < s[m] || s[index] == 0)
                {
                    index++;
                }

                else if (s[index] >= s[m])
                {
                    if (s[index] < max)
                    {
                        index++;
                    }

                    else
                    {
                        result++;
                        s[index] = 0;
                        max = s.Max();
                        index++;
                    }
                }
            }

            else
            {
                if (index == s.Length)
                {
                    index = 0;
                }
            }
        }

        Console.WriteLine(result);
    }
}
