// проверить 2 числа, является ли одно из них квадратом другого.

Console.Write("a = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2 || number2 == number1 * number1) Console.WriteLine("Да");
else Console.WriteLine("Нет");