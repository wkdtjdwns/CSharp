int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

if (n <= 25)
{
    Console.WriteLine(str);
}

else
{
    string remain = str.Substring(12, n - 24);
    string result = remain.Contains(".") ?
                 str.Substring(0, 9) + "......" + str.Substring(n - 10) :
                 str.Substring(0, 11) + "..." + str.Substring(n - 11);

    Console.WriteLine(result);
}
