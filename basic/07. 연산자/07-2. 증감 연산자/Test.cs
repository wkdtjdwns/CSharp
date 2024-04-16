int x = 100;
int y = 100;

Console.WriteLine("x : " + x); // 100

int sum = x++ + y;

// 증감 연산자를 앞에 쓸 때의 연산
Console.WriteLine("x++ + y : " + sum); // x++ + y : 200

// 연산을 하고 나서 x값 확인
Console.WriteLine("x : " + x); // 101

Console.WriteLine();

x = 100;
y = 100;

Console.WriteLine("x : " + x); // 100

sum = ++x + y;


// 연산을 하기 전에 x값 확인
Console.WriteLine("x : " + x); // 101

// 증감 연산자를 뒤에 쓸 때의 연산
Console.WriteLine("++x + y : " + sum); // 201
