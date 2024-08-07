int n = int.Parse(Console.ReadLine());
int[] people = new int[n];
for (int i = 0; i < n; i++)
{
    people[i] = i + 1;
}

string[] line = Console.ReadLine().Split(" ");
int cnt = 0;
for (int i = 0; i < n; i++)
{
    if (people[i] != int.Parse(line[i]))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
