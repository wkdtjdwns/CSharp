int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
long result = 0;
int temp = 0;
bool isNum = false;

for (int i = 0; i < n; i++)
{
    char c = str[i];
    if (char.IsDigit(c))
    {
        if (!isNum)
        {
            isNum = true;
            temp = c - '0';
        }

        else
        {
            temp = temp * 10 + (c - '0');
        }
    }

    else
    {
        if (isNum)
        {
            result += temp;
            isNum = false;
            temp = 0;
        }
    }
}

if (isNum)
{
    result += temp;
}

Console.WriteLine(result);
