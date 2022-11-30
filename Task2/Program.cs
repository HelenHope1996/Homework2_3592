/*Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}


else if(number > 999)
{
    int number3 = number % 1000;
    int number4 = number3 / 100;
    Console.WriteLine($"{number4}");
    return;
}

int number1 = number % 100;
int number2 = number1 / 10;


Console.WriteLine($"{number2}");