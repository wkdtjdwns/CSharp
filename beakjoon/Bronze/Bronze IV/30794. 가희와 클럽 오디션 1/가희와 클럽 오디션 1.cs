string[] lvSign = Console.ReadLine().Split(" ");
int lv = int.Parse(lvSign[0]);
string sign = lvSign[1];

if (sign.Equals("miss")) Console.WriteLine(0);
else if (sign.Equals("bad")) Console.WriteLine(200 * lv);
else if (sign.Equals("cool")) Console.WriteLine(400 * lv);
else if (sign.Equals("great")) Console.WriteLine(600 * lv);
else Console.WriteLine(lv * 1000);
