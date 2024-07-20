int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    if (str[str.Length / 2 - 1] == str[str.Length / 2]) { Console.WriteLine("Do-it"); }
    else { Console.WriteLine("Do-it-Not"); }
}
