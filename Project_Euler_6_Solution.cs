using System;

class Program
{
    static double sum_of_squares(int v)
    {
        double sum = 0;
        for (int i = 1; i <= v; i++)
        {
            sum += Math.Pow(i, 2);
        }
        return sum;
    }
    static int summ(int v)
    {
        int sum = 0;
        for (int i = 1; i <= v; i++)
        {
            sum += i;
        }
        return sum;
    }
    public static void Main(string[] args)
    {
        int n = 100;

        double ss = sum_of_squares(n);
        double s = Math.Pow(summ(n), 2);

        Console.WriteLine(s - ss);
    }
}
