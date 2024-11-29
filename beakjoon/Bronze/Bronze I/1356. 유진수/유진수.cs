string str = Console.ReadLine();
char[] c = str.ToCharArray();
int[] a = new int[str.Length];
int[] b = new int[str.Length];
for (int i = 0; i < str.Length - 1; i++)
{
    int j = str.Length - 1 - i;
    if (i == 0)
    {
        a[i] = (int)(c[i] - '0');
        b[j] = (int)(c[j] - '0');
        continue;
    }

    a[i] = a[i - 1] * (int)(c[i] - '0');
    b[j] = b[j + 1] * (int)(c[j] - '0');
}

bool check = false;
for (int i = 0; i < str.Length - 1; i++)
{
    if (a[i] == b[i + 1])
    {
        check = true;
        break;
    }
}

Console.WriteLine(check ? "YES" : "NO");
