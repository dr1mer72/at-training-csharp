using System;   // Namespace Usage

class Practice1 {   // Class declaration
  static void Main() {  // Metod declaration
    
    int result;   // Variable declaration
    
    Console.Write("Введите число в десятичной системе: ");  // Message output
    int numb = Convert.ToInt32(Console.ReadLine());   // Variable declaration and type conversion
    
    Console.Write("Введите основание: ");   // Message output
    int bas = Convert.ToInt32(Console.ReadLine());  // Variable declaration and type conversion
    
    if (bas < 2)  // Declaring the first condition
    {
    Console.WriteLine("Введите число от 2 до 20");  // Message output
    return;   // Cycle completion
    }
    else if (bas > 20)  // Declaring the second condition
    {
    Console.WriteLine("Введите число от 2 до 20");  // Message output
    return;   // Cycle completion
    }
    
    result = numb % bas;  // Formula for calculating the result
    
    
    if (result < bas)   // Declaring the first settlement condition
      {
      Console.WriteLine("Результат: " + result);  // Message output
      }
    else
    {
      result = result % bas;  // Formula to match the condition
      Console.WriteLine("Результат: " + result);  // Message output
    }
  }
}