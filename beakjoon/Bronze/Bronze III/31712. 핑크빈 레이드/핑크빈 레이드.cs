string[] td1 = Console.ReadLine().Split(" ");
int t1 = int.Parse(td1[0]);
int d1 = int.Parse(td1[1]);

string[] td2 = Console.ReadLine().Split(" ");
int t2 = int.Parse(td2[0]);
int d2 = int.Parse(td2[1]);

string[] td3 = Console.ReadLine().Split(" ");
int t3 = int.Parse(td3[0]);
int d3 = int.Parse(td3[1]);

int n = int.Parse(Console.ReadLine()) - d1 - d2 - d3;
int result = 0;
if (n > 0)
{
    for (int i = 1; ; i++)
    {
        if (i % t1 == 0)
        {
            n -= d1;
        }

        if (i % t2 == 0)
        {
            n -= d2;
        }

        if (i % t3 == 0)
        {
            n -= d3;
        }

        if (n <= 0)
        {
            result = i;
            break;
        }
    }
}

Console.WriteLine(result);
