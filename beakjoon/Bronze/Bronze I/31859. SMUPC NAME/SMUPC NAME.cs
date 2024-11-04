string[] ns = Console.ReadLine().Split(" ");
int n = int.Parse(ns[0]);
string s = ns[1];

string unique = new string(s.Distinct().ToArray());
int cnt = s.Length - unique.Length;

string step2 = unique + (cnt + 4);
string step3 = (n + 1906) + step2;

char[] c = step3.ToCharArray();
Array.Reverse(c);

string step4 = new string(c);
Console.WriteLine("smupc_" + step4);
