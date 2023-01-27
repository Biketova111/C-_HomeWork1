/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите первое число: ");
string numberStr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);

Console.Write("Введите второе число: ");
string numberStr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberStr2);

Console.Write("Введите третье число: ");
string numberStr3 = Console.ReadLine();
int number3 = Convert.ToInt32(numberStr3);

if (number1>number2)
{
    if (number1>number3)
    {
        Console.WriteLine(number1);
    }
    else
    {
       Console.WriteLine(number3); 
    }
}
else
{
    if (number2>number3)
    {
      Console.WriteLine(number2);  
    }
    else
    {
        Console.WriteLine(number3);
    }
}
