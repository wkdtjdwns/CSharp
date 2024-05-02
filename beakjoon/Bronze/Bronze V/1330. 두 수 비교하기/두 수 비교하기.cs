string input = Console.ReadLine();
string[] valueArray = input.Split(' ', StringSplitOptions.None);

int A = Convert.ToInt32(valueArray[0]);
int B = Convert.ToInt32(valueArray[1]);

if (A > B) Console.WriteLine(">");
else if (A < B) Console.WriteLine("<");
else Console.WriteLine("==");
