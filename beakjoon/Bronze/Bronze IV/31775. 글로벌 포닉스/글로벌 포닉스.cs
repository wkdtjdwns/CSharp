bool isStartL = false;
bool isStartK = false;
bool isStartP = false;

for (int i = 0; i < 3; i++)
{
    string str = Console.ReadLine();
    if (str.StartsWith("l")) { isStartL = true; }
    if (str.StartsWith("k")) { isStartK = true; }
    if (str.StartsWith("p")) { isStartP = true; }
}

if (isStartL && isStartK && isStartP) { Console.WriteLine("GLOBAL"); }
else { Console.WriteLine("PONIX"); }
