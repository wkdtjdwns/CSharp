string myMbti = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

int cnt = 0;
for (int i = 0; i < n; i++)
{
    string mbti = Console.ReadLine();
    if (myMbti.Equals(mbti))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
