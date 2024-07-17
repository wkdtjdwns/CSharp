int n = int.Parse(Console.ReadLine());
while (true)
{
    int num = int.Parse(Console.ReadLine());
    if (num == 0) {  break; }

    if (num % n == 0) { Console.WriteLine(num + " is a multiple of " + n + "."); }
    else { Console.WriteLine(num + " is NOT a multiple of " + n + "."); }
}
