# 문자열 보간 (포멧)

- 문자열 연결의 일종으로 변수 값을 문자열의 자리 표시자로 대체하는 방법임.
- 사용법 : `$”문자열 {변수명}” {변수명};` 의 꼴로 사용함

```csharp
string first_name = "김";
string last_name = "성일";

string name = $"저의 이름은 : " {first_name} {last_name};

Console.WriteLine(name); // 저의 이름은 : 김 성일
```

---

- **`string.Format()`** 사용
  
    - 사용법 : `string.Format(”문자열 {0} 문자열 {1}”, {0}에 들어갈 변수명, {1}에 들어갈 변수명);` 의 꼴로 사용함.

```csharp
string first_name = "김";
string last_name = "성일";

string name = string.Format("저의 이름은 : {0} {1}", first_name, last_name);

Console.WriteLine(name); // 저의 이름은 : 김 성일
```
