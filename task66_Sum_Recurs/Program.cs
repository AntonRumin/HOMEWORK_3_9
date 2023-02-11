/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Clear();

Console.WriteLine(" - - - Расчет суммы натуральных чисел от 1 до N - - - ");
Console.WriteLine();

int GetNumber(string msg)
{
    int result = 0;

    while(true)
    {
        Console.Write(msg);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод.");
        }
    }
    return result;
}

int numberMin = 0;
int numberMax = 0;

int x = GetNumber ("Введите Первое натуральное число : ");
int y = GetNumber ("Введите Второе натуральное число : ");

if (x < y)
{
    numberMin = x; 
    numberMax = y;
}
else if (x > y)
{
    numberMin = y;
    numberMax = x;
}
else
{ 
    Console.WriteLine($"Сумма натуральных чисел от {x} до {y} равна {x+y}");// По условиям при подсчете суммы границы учитываются
}
// Решение без рекурсии (через цикл)

int sum = 0;

for (int i = numberMin ; i<= numberMax; i++)
{
    sum = sum + i;
}

Console.WriteLine();
Console.WriteLine ("1. Расчет суммы с помощью цикла: ");
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {numberMin} до {numberMax} равна {sum}");
Console.WriteLine();

// Решение с рекурсией (без цикла)

int NumberRow (int c, int num)
{
if (c <= num) return c + NumberRow (c + 1, num);
else return 0;
}
Console.WriteLine ("2. Расчет суммы с помощью рекурсии: ");
Console.WriteLine();
Console.WriteLine ($"Сумма натуральных чисел от {numberMin} до {numberMax} равна {NumberRow(numberMin,numberMax)}");