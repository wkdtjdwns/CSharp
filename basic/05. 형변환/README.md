# 형변환

### **암시적 형변환**

---

- **정의 :** 작은 자료형을 큰 자료형으로 **자동으로 변환**함.
- 암시적 형변환은 **자료의 값이 손상되지 않음**.
- `char` → `int` →  `long` →  `float` → `double` 순서

```csharp
int my_int = 9;
double my_double = my_int; // 암시적 형변환 (int -> double)

Console.WriteLine(my_int);    // 9 출력
Console.WriteLine(my_double); // 9 출력
```

---

### **명시적 형변환**

---

- **정의 :** 자료형을 **개발자가 수동으로 변환**함.
- 명시적 형변환은 **자료의 값이 손상될 수 있음**.

```csharp
double my_double = 9.78;
int my_int = (int) my_double;

// 소수인 9.78을 정수로 바꾸느라 소수점 이하의 숫자를 버림.
// -> 자료의 값이 손상됨.
Console.WriteLine(my_double);   // 9.78 출력
Console.WriteLine(my_int);      // 9 출력
```

---

### 형변환 방법

---

- **Convert 클래스 사용**
    
    ---
    
    ```csharp
    int my_int = 10;
    double my_double = 5.25;
    bool my_bool = true;
    
    Console.WriteLine(Convert.ToString(my_int));   // int -> string
    Console.WriteLine(Convert.ToDouble(my_int));   // int -> double
    Console.WriteLine(Convert.ToInt32(my_double)); // double -> int
    Console.WriteLine(Convert.ToString(my_bool));  // bool -> string
    ```
    
    ---
    
    - ToInt16(), ToInt32(), ToInt64()의 차이점
    
    | 메소드 | 설명 |
    | --- | --- |
    | ToInt16() | 파라미터의 값을 16비트 부호 있는 정수로 변환함 |
    | ToInt32() | 파라미터의 값을 32비트 부호 있는 정수로 변환함 (대부분 이거 씀) |
    | ToInt16() | 파라미터의 값을 64비트 부호 있는 정수로 변환함 |
