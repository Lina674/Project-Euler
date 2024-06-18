using System;

class Program
{

    static double reverse(double n)
    {
        double r = 0;
        for (int i = n.ToString().Length; i != 0; i--)
        {
            int remainder = (int)n % 10;
            n /= 10;
            r += remainder * Math.Pow(10, (i - 1));
        }
        return r;
    }

    public static void Main(string[] args)
    {
        int digit = 3;

        bool found = false;
        for (double i = Math.Pow(10, digit) - 1; i > Math.Pow(10, digit) - 200 && !found; i--)
        {
            for (double j = Math.Pow(10, digit) - 1; j > Math.Pow(10, digit) - 200; j--)
            {
                double product = i * j;
                if (product == reverse(product))
                {
                    Console.WriteLine(product);
                    found = true;
                    break;
                }
            }
        }
    }
}
