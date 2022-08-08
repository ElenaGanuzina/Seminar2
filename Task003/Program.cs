// 2 числа на вход, является ли второе кратным первому. Если число 2 не кратно числу 1, то вывести остаток от деления

Console.Write("а = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == 0) Console.WriteLine("Введите число, отличное от нуля");
if(number2 % number1 == 0)
{
    Console.Write("Кратно");
}
else
{
    int result = number2 % number1;
    Console.Write($"Не кратно, остаток {result}");
}