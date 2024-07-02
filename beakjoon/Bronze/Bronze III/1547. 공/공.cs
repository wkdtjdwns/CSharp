int m = int.Parse(Console.ReadLine());
int[] array = { 1, 2, 3 };

for (int i = 0; i < m; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    int temp = array[a - 1];
    array[a - 1] = array[b - 1];
    array[b - 1] = temp;
}

for (int i = 0; i < 3; i++)
{
    if (array[i] == 1) { Console.WriteLine(i + 1); }
}
