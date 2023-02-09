/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

Console.Clear();

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

// Решение без рекурсии (через цикл)

int GetRow(int num)
{
int m = num - 1;

return m; 
}

int number = GetNumber ("Введите натуральное число : ");

Console.WriteLine ($"Числовой ряд от {number} до 1");
Console.WriteLine ("1. С помощью цикла: ");

for (int i = number; i >= 1; i--)
{
int a = GetRow(i) + 1;

Console.Write(a + " ; ");

}
Console.WriteLine();

// Решение с рекурсией (без цикла)

string NumberRow (int c, int num)
{
if (num >= c) return $"{num} " + ", " + NumberRow (c, num-1);
else return String.Empty;
}
Console.WriteLine ("2. С помощью рекурсии: ");
Console.Write (NumberRow(1,number));