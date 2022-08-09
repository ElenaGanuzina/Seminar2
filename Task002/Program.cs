// Вывести трехзначное число, удалить из него вторую цифру, вывести результат.

int number1 = new Random().Next(100, 1000);
Console.WriteLine(number1);
int number2 = (number1 / 100) * 10 + number1 % 10;
Console.WriteLine(number2);