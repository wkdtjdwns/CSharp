string[] num = Console.ReadLine().Split(" ");
int[] abc = new int[3];
for (int i = 0; i < 3; i++) { abc[i] = int.Parse(num[i]); }

Array.Sort(abc);

string str = Console.ReadLine();
foreach (char c in str) {
    if (c == 'A') { Console.Write(abc[0] + " "); }
    else if (c == 'B') { Console.Write(abc[1] + " "); }
    else { Console.Write(abc[2] + " "); }
}
