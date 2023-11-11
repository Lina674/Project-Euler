using System;

class Program {
  public static void Main (string[] args) {
    int input= Convert.ToInt32(Console.ReadLine());
    int sumthree=0;
    int sumfive=0;
    int sumfiveplus=0;

      for (int j=1; 3*j<input; j++) {
          sumthree+=3*j;

          if ((3*j)%5==0){
            sumfiveplus+=3*j;
         }
      }

      for (int k=1; 5*k<input; k++) {
          sumfive+=5*k;
      }

    int sum=sumfive + sumthree;
    int sumplus=sum-sumfiveplus;

    Console.WriteLine(sumplus);
  }
}
