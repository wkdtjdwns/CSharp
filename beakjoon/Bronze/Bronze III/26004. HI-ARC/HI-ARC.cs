int n = int.Parse(Console.ReadLine());
char[] str = Console.ReadLine().ToCharArray();
int[] hiarc = { 0, 0, 0, 0, 0 };
foreach (char s in str)
{
    switch (s)
    {
        case 'H':
            hiarc[(int)Character.H]++;
            break;

        case 'I':
            hiarc[(int)Character.I]++;
            break;

        case 'A':
            hiarc[(int)Character.A]++;
            break;

        case 'R':
            hiarc[(int)Character.R]++;
            break;

        case 'C':
            hiarc[(int)Character.C]++;
            break;
    }
}

Console.WriteLine(hiarc.Min());

enum Character : int
{
    H, I, A, R, C, _,
}
