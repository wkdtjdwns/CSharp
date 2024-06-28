for (int i = 0; i < 15; i++)
{
    string pixel = Console.ReadLine();
    foreach (char c in pixel)
    {
        if (c == 'w')
        {
            Console.WriteLine("chunbae");
            return;
        }

        else if (c == 'b')
        {
            Console.WriteLine("nabi");
            return;
        }

        else if (c == 'g')
        {
            Console.WriteLine("yeongcheol");
            return;
        }
    }
}
