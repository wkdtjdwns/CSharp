string str;
while ((str = Console.ReadLine()) != null)
{
    int small = 0;
    int big = 0;
    int num = 0;
    int space = 0;

    for (int i = 0; i < str.Length; i++)
    {
        char c = str[i];
        if (c == ' ')
        {
            space++;
        }

        else if (Char.IsUpper(c))
        {
            big++;
        }

        else if (Char.IsLower(c))
        {
             small++;
        }

        else if (Char.IsDigit(c))
        {
            num++;
        }
    }

    Console.WriteLine($"{small} {big} {num} {space}");
}
