string aeiou = "aeiou";

while (true)
{
    string str = Console.ReadLine();

    if (str == "#")
    {
        break;
    }

    if (aeiou.Contains(str[0]))
    {
        Console.WriteLine(str + "ay");
    }

    else
    {
        int index = 0;
        while (index < str.Length && !aeiou.Contains(str[index]))
        {
            index++;
        }

        string result = str.Substring(index) + str.Substring(0, index) + "ay";
        Console.WriteLine(result);
    }
}
