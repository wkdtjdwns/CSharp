# 사용자 입력 받기

- 기본적으로 C#은 `Console.ReadLine()` 을 사용해서 사용자의 입력을 받아옴.

### 1. string형 입력

---

- `Console.ReadLine()` : **사용자의 “키보드” 입력을 “string”형으로 받아오는 함수**임.

```csharp
// 입력하기 전에 출력해서 입력을 해야한다고 알려줌
Console.Write("Enter username >>> ");

// Console.ReadLine(); -> 사용자의 키보드 입력을 받아옴
string user_name = Console.ReadLine();

// 위에서 받은 입력을 변수에 저장한 뒤 출력함
Console.WriteLine("Username is : " + user_name );

/*
 * Enter username >>> ㅇㅇㅇ
 * Username is : ㅇㅇㅇ
 * -------------------------  입력 값 변경
 * Enter username >>> 김성일
 * Username is : 김성일
 */
```

---

### 2. 다른 자료형 입력

---

- `Console.ReadLine()` : string형으로 값을 받아와서 다른 자료형으로 따로 형변환을 해주어야 함.

```csharp
Console.Write("Enter your age >>> ");
// int age = Console.ReadLine(); 오류가 생김
int age = Convert.ToInt32(Console.ReadLine()); // string 타입의 값을 int형으로 변환함
Console.WriteLine("Your age is: " + age);

/*
 * Cannot implicitly convert type 'string' to 'int'
 * 뜻 : string 타입의 값을 int형 변수에 넣을 수 없음.
 * -> string 타입은 int형으로 자동 형변환이 되지 않음.
 */

/*
 * Enter your age >>> 18
 * Your age is: 18
 * ---------------------- 입력 값 변경
 * Enter your age >>> 33
 * Your age is: 33
 */
```
