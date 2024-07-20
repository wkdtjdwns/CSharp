int a = int.Parse(Console.ReadLine());
int result = a;
while (true)
{
    string op = Console.ReadLine();
    if (op.Equals("=")) { break; }

    int b = int.Parse(Console.ReadLine());
    if (op.Equals("+")) { result += b; }
    else if (op.Equals("-")) { result -= b; }
    else if (op.Equals("*")) { result *= b; }
    else { result /= b; }
}

Console.WriteLine(result);
