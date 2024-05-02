using System.Numerics;

string input = Console.ReadLine();
string[] valueArray = input.Split(' ', StringSplitOptions.None);

// 문자열로 받기 때문에 길이 상관 X
BigInteger N = BigInteger.Parse(valueArray[0]);
BigInteger M = BigInteger.Parse(valueArray[1]);

BigInteger divided = N / M;
BigInteger remained = N % M;

Console.WriteLine(divided);
Console.WriteLine(remained);
