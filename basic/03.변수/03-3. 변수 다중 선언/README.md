- **같은 자료형의 변수**들은 **한꺼번에 선언**할 수 있음.
    
    ```csharp
    int x = 5, y = 6, z = 50;
    Console.WriteLine(x + y + z); // 61
    ```
    
    ---
    
    ```csharp
    int x, y, z;
    x = y = z = 50;
    
    Console.WriteLine(x + y + z); // 150
    ```
