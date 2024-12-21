using System.Text;

string[] strs = Console.ReadLine().Split(" ");
Console.Write(char.ToUpper(strs[0][0]));

int i = 0;
foreach (string str in strs)
{
    if (i++ == 0)
    {
        continue;
    }

    if (str == "i" || str == "pa" || str == "te" || str == "ni" || str == "niti" ||
        str == "a" || str == "ali" || str == "nego" || str == "no" || str == "ili")
    {
        continue;
    }

    Console.Write(char.ToUpper(str[0]));
}
