int i = 1;
while (true)
{
    string[] abc = Console.ReadLine().Split(" ");

    double a = double.Parse(abc[0]);
    int b = int.Parse(abc[1]);
    double c = double.Parse(abc[2]);

    if (b == 0) { break; }

    double distance = 3.1415927 * a * b / 63360.0;
    double mph = distance / (c / 3600.0);

    Console.WriteLine($"Trip #{i}: {distance:F2} {mph:F2}");
    i++;
}
