string str = Console.ReadLine();
int result = 1;

char c = str[0];
for (int i = 1; i < str.Length; i++)
{
    char next = str[i];
    if (next - 'a' <= c - 'a')
    {
        result++;
    }

    c = next;
}

Console.WriteLine(result);
