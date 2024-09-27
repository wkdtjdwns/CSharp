int c = int.Parse(Console.ReadLine());
for (int i = 0; i < c; i++)
{
    string[] a = Console.ReadLine().Split(" ");
    int n = int.Parse(a[0]);
    double sum = 0.0f;
    int[] students = new int[n];
    for (int j = 0; j < n; j++)
    {
        students[j] = int.Parse(a[j + 1]);
        sum += students[j];
    }
    
    double avg = sum / n;
    double cnt = 0.0f;
    foreach (int student in students)
    {
        if (student > avg)
        {
            cnt++;
        }
    }

    double result = 100 / (n / cnt);
    Console.WriteLine(result.ToString("F3") + "%");
}
