using System;   // Namespace Usage

class Practice1 {   // Class declaration
  static void Main() {  // Metod declaration
    
    string result = "";   // Declaring a Variable for the Result
    
    Console.WriteLine("Введите число в десятичной системе: ");  // Message output
    int numb = Convert.ToInt32(Console.ReadLine());   // Variable declaration and type conversion
    
    Console.WriteLine("Введите основание: ");   // Message output
    int bas = Convert.ToInt32(Console.ReadLine());  // Variable declaration and type conversion
    
    if (bas < 2)  // Declaring the first condition
    {
    Console.WriteLine("Ошибка: Введите число от 2 до 20");  // Message output
    return;   // Cycle completion
    }
    else if (bas > 20)  // Declaring the second condition
    {
    Console.WriteLine("Ошибка: Введите число от 2 до 20");  // Message output
    return;   // Cycle completion
    }
    
    int temp = 0;   // Declaring a temporary variable
    
    if (numb > 0)     // The condition that the number is greater than 0
                while (numb >= (bas - 1))   // Loop until the number is greater than the base
                {
                    temp = numb % bas;      
                    numb = (numb - temp) / bas;
                    result = Convert.ToString(temp) + result;
                }
    result = Convert.ToString(numb) + result;
    Console.WriteLine("Результат: " + result);  // Message output
  }
}