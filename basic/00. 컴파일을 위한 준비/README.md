# 컴파일을 위한 준비

1. 아래의 링크를 타고 가서 Visual Studio를 설치함. (Visual Studio Code도 무관함.)
    - 만약 Unity를 설치했었다면 이미 깔려 있었을 수 있음.
      
    <p><a href = "https://visualstudio.microsoft.com/ko/downloads" title = "Visual Studio Download Site)"> Visual Studio Download </a></p>
   
2. 아래와 같이 C# 파일들을 저장할 폴더를 만들어 줌.

    ![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/9b5a829a-90ab-4551-a8fe-781475544a0c)

<hr>

<details>
  <summary><strong><h2>Visual Studio</strong></h2></summary>
<p><strong>1. 설치할 때 아래와 같이 설정한 뒤에 다운로드 받으면 됨.</strong> (Github Copilot은 아래에서 설명함.)</p>

![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/c2d93c82-39a8-4b5d-86c1-2bb1222d4764)
    
<hr>
    
<strong>2. 새 프로젝트 생성</strong> (아래의 사진과 같이 하면 됨.)
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/f93ff75b-6301-440a-b4c9-c47801b665a0)
    
<hr>
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/3d3e7bda-a4a6-4d4f-8211-21eba02adaf4)
- 빨간 사각형을 클릭한 뒤에 다음 버튼 클릭    
<hr>
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/19d22061-8a7b-430f-a253-16dc83fa4465)

<hr>
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/9d35a960-1dde-4815-89a6-2eaeaca9b72b)
    
<hr>

![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/6ce2b47a-a262-4843-945b-011cfdd9b796)
- 설치할 때 Github Copilot을 설치했을 때 생기는 것 → 로그인하고 깃허브 연결하면 없어짐

<details>
  <summary><strong><h3>Github Copilot 사용 (유로임)</strong></h3></summary>
    
+ Github Copilot이란 Github에서 공개된 레포지토리의 사용 가능한 코드들을 AI가 학습해서 우리에게 작성 중인 코드의 방향? 을 제시함.
+ 또한 주석에 코드를 설명하면 코드로 바꿔줌

https://github.com/wkdtjdwns/CSharp/assets/128266768/5a3d1810-a29e-459e-a448-82526cd6d9a3
    
<hr>
    
- 아무튼 이런 Github Compilot을 설치하기 위해선 Visual Studio에 로그인하고 Github와 연결해야 함.
- 아래와 같이 Microsoft로 로그인 한뒤에 +추가를 클릭해 Github 계정과 연결하면 됨.
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/a796b20f-1ffe-4121-a739-1ef82774ae77)

- 로그인 후의 계정추가
    
<hr>
    
- 그 뒤에 프로젝트로 돌아가면 아래의 사진과 같은 문구가 떠있는데, 여기서 Singup ~~~를 누르고 들어가서 결재한 뒤에 사용하면 끝!
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/5f8db5ef-9a22-4379-a4b7-01c40239c32e)
    
<hr>
    
- 결재 안 하면 맨날 아래의 메세지가 뜨니깐 귀찮으면 지우자~

![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/e4f601c5-88f2-4f55-abdd-8f0e66e165a5)

    
<hr>

![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/2d0edd60-3af5-4d56-948b-c7d73f6cd5f1)

</details>
    
</details>
<hr>
<details>
  <summary><strong><h2>Visual Studio Code</strong></h2></summary>
    
1. C#을 사용하기 위해선 .Net의 최신 버전을 다운로드 받아야 함. (아래 링크에서 자신의 컴퓨터 사양에 맞는 최신 버전 설치)

<p><a href = "https://dotnet.microsoft.com/en-us/download/visual-studio-sdks" title = ".NET SDKs downloads for Visual Studio)"> .NET SDK Download </a></p>
        
<hr>
        
2. VSC를 설치한 다음 아래 이미지와 같은 화면이 나오면 만들어 놨던 폴더 열어줌.
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/63836715-3a39-43a1-a0fb-272b6b069a11)
    
<hr>
    
3. 폴더를 열면 아래와 같은 창이 뜨는데… 대충 해석하면 “너 이 폴더 신뢰할 수 있니?”라는 뜻이니 Yes 눌러주면 됨.
    
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/5d9eae6f-05b4-4c0d-a7ac-6dada15f3cd4)

<hr>
    
4. 그 다음 파일을 생성할 껀데 2가지 방법이 있음 (아래의 2가지 방법 중 편한거 사용)
      - EXPLORER 창 더블클릭 → 아래 이미지에 있는 파란 사각형 안을 더블클릭
      
      ![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/a9475382-68bd-4347-8992-2c9c48bdd696)
      
      <hr>
      
      - 파일 생성 버튼 클릭
                  
      ![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/c0b3bdfd-7a16-4fdc-a309-5f6d88057226)

            
<hr>
            
5. 아무튼 파일을 생성하고 파일 이름을 `파일명.cs` 로 설정함. (C# 파일 확장자 : cs)
6. 그 다음 아래의 이미지에 있는 버튼을 눌러서 <strong>확장<strong>에 들어감.
        
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/8345af49-c778-48ff-9ca6-6e0de055fad0)
    
<hr>
        
7. 아래에 있는 확장들을 설치해 줌.
        
![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/a88dab5c-3c28-48e4-8a3a-244310f003bc)
        
<hr>
        
8. 설치 후 ⭐`Ctrl + Shift + P`를 눌러 확장을 실행함.
9. ⭐`.Net New Project > Console App > 프로젝트 이름 적기 → 생성 폴더 결정`의 경로로 프로젝트를 생성함.
</details>
