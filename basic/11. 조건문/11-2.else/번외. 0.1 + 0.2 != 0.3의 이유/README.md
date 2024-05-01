# 0.1 + 0.2 != 0.3의 이유

- **컴퓨터가 대부분의 소수를 저장하는 방식**
    
    ![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/041b9632-23cd-4bb1-a290-33944c07da46)
    
    ![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/7297a435-8400-4805-90c0-e71a60c6e96c)
    
- **순환소수 문제**
    - 위와 같은 방식으로 모든 소수를 저장할 수는 없음.
    - “순환소수”를 2진수로 변환하면 무한대로 이어짐.
        - ex) 0.1 =0.0011001100110011001100...........…
    - 이렇게 되면 숫자를 저장할 수 있는 칸이 무한대여야 하는데… 이건 불가능함.
    - 그래서 칸이 부족하면 그 값들은 잘라냄. → 오차 발생
    
    ![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/0a2e10fa-a1d9-419c-8561-7125ec60e99d)
