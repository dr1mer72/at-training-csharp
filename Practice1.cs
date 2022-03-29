using System;

class Practice1 {
  static void Main() {
    int numb;
    int bas;
    int result;
    
    numb = 159;
    bas = 20;
    
    if (bas < 2)
    {
    Console.WriteLine("Введите число от 2 до 20");
    return;
    }
    else if (bas > 20)
    {
    Console.WriteLine("Введите число от 2 до 20");
    return;
    }
    
    result = numb % bas;
    
    
    if (result < bas)
      {
      Console.WriteLine("Результат: " + result);
      }
    else 
    {
      result = result % bas;
      Console.WriteLine("Результат: " + result);
    }
  }
}