string str = Console.ReadLine();
int happy = 0;
int sad = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == ':' && str[i + 1] == '-')
    {
        if (str[i + 2] == ')')
        {
            happy++;
        }

        else if (str[i + 2] == '(')
        {
            sad++;
        }
    }
}

if (happy == 0 && sad == 0)
{
    Console.WriteLine("none");
}

else if (happy > sad)
{
    Console.WriteLine("happy");
}

else if (happy < sad)
{
    Console.WriteLine("sad");
}

else
{
    Console.WriteLine("unsure");
}
