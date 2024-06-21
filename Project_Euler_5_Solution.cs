using System;

class Program
{
    public static void Main(string[] args)
    {
        int initial = 20;
        while (true)
        {
            bool divisibleByAll = true;
            for (int i = 1; i <= 20; i++)
            {
                if (initial % i != 0)
                {
                    divisibleByAll = false;
                    break;
                }
            }
            if (divisibleByAll)
            {
                break;
            }
            initial += 20;
        }
        Console.WriteLine(initial);
    }
}
