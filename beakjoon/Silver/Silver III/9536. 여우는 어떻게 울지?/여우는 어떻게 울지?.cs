int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    List<string> list = new List<string>();
    string[] sounds = Console.ReadLine().Split(" ");
    foreach (string sound in sounds)
    {
        list.Add(sound);
    }

    string str;
    while (!(str = Console.ReadLine()).Equals("what does the fox say?"))
    {
        string[] ags = str.Split(" ");
        string s = ags[2];

        while (list.Contains(s))
        {
            list.Remove(s);
        }
    }

    foreach (string result in list)
    {
        Console.Write(result + " ");
    }

    Console.WriteLine();
}
