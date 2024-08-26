int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] ck = Console.ReadLine().Split(" ");
    double cm = double.Parse(ck[0]);
    double kg = double.Parse(ck[1]);
    double bmi = kg / (cm * cm / 10000);
    if (cm < 140.1)
    {
        Console.WriteLine(6);
    }

    else if (cm < 146)
    {
        Console.WriteLine(5);
    }

    else if (cm < 159)
    {
        Console.WriteLine(4);
    }

    else if (cm < 161)
    {
        if (bmi >= 16.0 && bmi < 35.0)
        {
            Console.WriteLine(3);
        }

        else
        {
            Console.WriteLine(4);
        }
    }

    else if (cm < 204)
    {
        if (bmi >= 20.0 && bmi < 25.0)
        {
            Console.WriteLine(1);
        }

        else if (bmi >= 18.5 && bmi < 20.0)
        {
            Console.WriteLine(2);
        }

        else if (bmi >= 25.0 && bmi < 30.0)
        {
            Console.WriteLine(2);
        }

        else if (bmi >= 16.0 && bmi < 18.5)
        {
            Console.WriteLine(3);
        }

        else if (bmi >= 30.0 && bmi < 35.0)
        {
            Console.WriteLine(3);
        }

        else
        {
            Console.WriteLine(4);
        }
    }

    else
    {
        Console.WriteLine(4);
    }
}
