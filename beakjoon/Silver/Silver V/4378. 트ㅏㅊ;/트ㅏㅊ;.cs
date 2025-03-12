char[,] keyboard =
{
    { '`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=' },
    { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', '[', ']', '\\' },
    { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', ';', '\'', '?', '?' },
    { 'Z', 'X', 'C', 'V', 'B', 'N', 'M', ',', '.', '/', '?', '?', '?' },
};

string str;

while ((str = Console.ReadLine()) != null)
{
    string result = "";
    foreach (char c in str)
    {
        if (c == ' ')
        {
            result += ' ';
            continue;
        }

        bool check = false;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                if (c == keyboard[i, j])
                {
                    result += keyboard[i, j - 1];
                    check = true;
                    break;
                }
            }

            if (check) { break; }
        }
    }

    Console.WriteLine(result);
}
