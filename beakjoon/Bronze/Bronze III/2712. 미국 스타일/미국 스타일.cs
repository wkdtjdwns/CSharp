using System.Text;

int t = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
for (int i = 0; i < t; i++)
{
    string[] valueUnit = Console.ReadLine().Split(" ");
    double value = double.Parse(valueUnit[0]);
    string unit = valueUnit[1];

    double resultValue = 0;
    string reusltUnit = "";
    string result = "";

    if (unit.Equals("kg"))
    {
        reusltUnit = "lb";
        resultValue = value * 2.2046;
    }

    else if (unit.Equals("l"))
    {
        reusltUnit = "g";
        resultValue = value * 0.2642;
    }

    else if (unit.Equals("lb"))
    {
        reusltUnit = "kg";
        resultValue = value * 0.4536;
    }

    else if (unit.Equals("g"))
    {
        reusltUnit = "l";
        resultValue = value * 3.7854;
    }

    result = resultValue.ToString("F4");

    sb.Append(result).Append(" ").Append(reusltUnit).Append("\n");
}

Console.WriteLine(sb);
