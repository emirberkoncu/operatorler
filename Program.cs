using System;

namespace Operatorler
{
  class Program
  {
    static void Main(string[] args)
    {
      // Atama ve işlemli atama
      int x = 3;
      int y = 3;
      y += 2;
      x *= 2;
      Console.WriteLine(y);
      Console.WriteLine(x);

      // || ve && ve !
      bool isSuccess = true;
      bool isCompleted = false;
      if( isSuccess && isCompleted ){
        Console.WriteLine("Perfect!");
      }
      if( isSuccess || isCompleted ){
        Console.WriteLine("Great!");
      }
      if(isSuccess && !isCompleted){
        Console.WriteLine("Fine!");
      }

      // İlişkisel Operatörler
      // ==, !=, <, >, <=, >=
      int a = 3;
      int b = 4;
      bool sonuc = a < b;
      Console.WriteLine(sonuc); 

      sonuc = a > b;
      Console.WriteLine(sonuc);

      sonuc = a >= b;
      Console.WriteLine(sonuc);

      sonuc = a <= b;
      Console.WriteLine(sonuc);

      sonuc = a == b;
      Console.WriteLine(sonuc);

      sonuc = a != b;
      Console.WriteLine(sonuc);

      // Aritmetik Operatorler
      // +, -, *, /
      int sayi = 10;
      int sayi2 = 5;
      int sonuc2 = sayi / sayi2;
      Console.WriteLine(sonuc2);
      int sonuc3 = sayi * sayi2;
      Console.WriteLine(sonuc3);

      // % : Mod alma
      int sonuc4 = 20 % 3;
      Console.WriteLine(sonuc4);

    }
  }
}