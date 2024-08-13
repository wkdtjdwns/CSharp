int n = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 1; i <= n; i++)
{
    string str = i.ToString();
    for (int j = 0; j < str.Length; j++)
    {
        if (str[j] == '3' || str[j] == '6' || str[j] == '9')
        {
            result++;
        }
    }
}

Console.WriteLine(result);
