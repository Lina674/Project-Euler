using System;

class Program {
  public static void Main (string[] args) {
    long n = 600851475143;
    for (int i = 2; i < Math.Sqrt(n); i++) {
      if (n % i == 0) {
        n = n / i;     
      }
    }
    Console.WriteLine(n);
  }
}
