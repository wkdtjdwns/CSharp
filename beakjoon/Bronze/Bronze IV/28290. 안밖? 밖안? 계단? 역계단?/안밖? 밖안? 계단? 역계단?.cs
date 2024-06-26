string str = Console.ReadLine();
if (str.Equals("fdsajkl;") || str.Equals("jkl;fdsa"))
{
    Console.WriteLine("in-out");
}

else if (str.Equals("asdf;lkj") || str.Equals(";lkjasdf"))
{
    Console.WriteLine("out-in");
}

else if (str.Equals("asdfjkl;"))
{
    Console.WriteLine("stairs");
}

else if (str.Equals(";lkjfdsa"))
{
    Console.WriteLine("reverse");
}

else
{
    Console.WriteLine("molu");
}
