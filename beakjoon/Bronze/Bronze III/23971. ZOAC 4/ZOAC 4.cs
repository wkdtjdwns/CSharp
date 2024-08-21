string[] hwnm = Console.ReadLine().Split(" ");
int h = int.Parse(hwnm[0]);
int w = int.Parse(hwnm[1]);
int n = int.Parse(hwnm[2]);
int m = int.Parse(hwnm[3]);

int f = (h - 1) / (n + 1) + 1;
int s = (w - 1) / (m + 1) + 1;

Console.WriteLine(f * s);
