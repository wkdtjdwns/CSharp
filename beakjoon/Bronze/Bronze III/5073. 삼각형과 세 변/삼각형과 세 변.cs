int[] array = new int[3];
while (true)
{
    string[] abc = Console.ReadLine().Split(" ");
    array[0] = int.Parse(abc[0]);
    array[1] = int.Parse(abc[1]);
    array[2] = int.Parse(abc[2]);

    if (array[0] == 0 && array[1] == 0 && array[2] == 0) break;

    Array.Sort(array);

    if (array[2] >= array[0] + array[1])
    {
        Console.WriteLine("Invalid");
    }

    else if (array[0] == array[1] && array[1] == array[2])
    {
        Console.WriteLine("Equilateral");
    }

    else if (array[0] == array[1] || array[1] == array[2] || array[0] == array[2])
    {
        Console.WriteLine("Isosceles");
    }

    else
    {
        Console.WriteLine("Scalene");
    }
}
