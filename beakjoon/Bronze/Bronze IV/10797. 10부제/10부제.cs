int day = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(" ");
int[] cars = new int[5];

for (int i = 0; i < 5; i++)
{
    cars[i] = int.Parse(input[i]);
}

int cnt = 0;
foreach (int car in cars)
{
    if (car == day)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
