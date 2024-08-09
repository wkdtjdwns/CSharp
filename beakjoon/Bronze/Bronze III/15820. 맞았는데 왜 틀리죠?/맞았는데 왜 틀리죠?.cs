string[] s = Console.ReadLine().Split(" ");
int s1 = int.Parse(s[0]);
int s2 = int.Parse(s[1]);

int[] answer = new int[s1 + s2];
int[] myAnswer = new int[s1 + s2];
bool sw = false;

for (int i = 0; i < s1 + s2; i++)
{
    string[] am = Console.ReadLine().Split(" ");
    answer[i] = int.Parse(am[0]);
    myAnswer[i] = int.Parse(am[1]);

    if (i < s1 && answer[i] != myAnswer[i])
    {
        Console.WriteLine("Wrong Answer");
        sw = true;
        break;
    }

    else if (i >= s1 && answer[i] != myAnswer[i])
    {
        Console.WriteLine("Why Wrong!!!");
        sw = true;
        break;
    }
}

if (!sw)
{
    Console.WriteLine("Accepted");
}
