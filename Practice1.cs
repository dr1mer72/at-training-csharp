using System;

class Practice1 {
  static void Main() {
    
    int result;
    
    Console.Write("Введите число в десятичной системе: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите основание: ");
    int bas = Convert.ToInt32(Console.ReadLine());
    
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