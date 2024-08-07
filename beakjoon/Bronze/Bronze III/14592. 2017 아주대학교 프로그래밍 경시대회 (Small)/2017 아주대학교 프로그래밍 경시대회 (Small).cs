int n = int.Parse(Console.ReadLine());
int[,] people = new int[n, 4];

for (int i = 0; i < n; i++)
{
    string[] p = Console.ReadLine().Split(" ");
    people[i, 0] = int.Parse(p[0]);
    people[i, 1] = int.Parse(p[1]);
    people[i, 2] = int.Parse(p[2]);
    people[i, 3] = i + 1;
}

int win = 0;
for (int i = 1; i < n; i++)
{
    if (people[i, 0] > people[win, 0] ||
            (people[i, 0] == people[win, 0] && people[i, 1] < people[win, 1]) ||
            (people[i, 0] == people[win, 0] && people[i, 1] == people[win, 1] && people[i, 2] < people[win, 2]))
    {

        win = i;
    }
}

Console.WriteLine(people[win, 3]);
