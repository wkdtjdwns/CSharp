int n = int.Parse(Console.ReadLine());
int[] result = new int[10];
for (int i = 1; i <= 10; i++) { result[i - 1] = ((i - 1) % 5) + 1; }
for (int i = 0; i < n; i++)
{
    string[] scores = Console.ReadLine().Split(" ");
    int cnt = 0;
    for (int j = 0; j < 10; j++)
    {
        if (int.Parse(scores[j]) == result[j]) { cnt++; }
    }

    if (cnt == 10) { Console.WriteLine(i + 1); }
}
