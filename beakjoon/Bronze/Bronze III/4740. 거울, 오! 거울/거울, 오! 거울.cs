while (true)
{
    string str = Console.ReadLine();
    if (str.Equals("***")) { break; }

    for (int i = str.Length - 1; i >= 0; i--) { Console.Write(str[i]); }
    Console.WriteLine();
}
