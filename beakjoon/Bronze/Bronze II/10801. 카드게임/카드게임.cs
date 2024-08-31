int[] a = new int[10];
int[] b = new int[10];

string[] aValues = Console.ReadLine().Split(" ");
for (int i = 0; i < 10; i++)
{
    a[i] = int.Parse(aValues[i]);
}

string[] bValues = Console.ReadLine().Split(" ");
for (int i = 0; i < 10; i++)
{
    b[i] = int.Parse(bValues[i]);
}

int aCnt = 0; int bCnt = 0; int dCnt = 0;
for (int i = 0; i < 10; i++)
{
    if (a[i] > b[i])
    {
        aCnt++;
    }

    else if (a[i] < b[i])
    {
        bCnt++;
    }

    else
    {
        dCnt++;
    }
}

if (aCnt > bCnt)
{
    Console.WriteLine("A");
}

else if (aCnt < bCnt)
{
    Console.WriteLine("B");
}

else
{
    Console.WriteLine("D");
}
