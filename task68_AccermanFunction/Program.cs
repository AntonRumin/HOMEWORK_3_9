/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


Console.Clear();

Console.WriteLine(" - - - Вычисление функции Аккермана для двух натуральных чисел - - - ");
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

int AccermanFunction (int m, int n)
{
    int value = 0;
    if (m == 0)  value = n + 1;
    if (m != 0 && n == 0) value =  AccermanFunction(m - 1, 1);
    if (m > 0 && n > 0) value = AccermanFunction (m - 1, AccermanFunction(m, n - 1));
    return value;
}

int num1 = GetNumber ("Введите Первое натуральное число : ");
int num2 = GetNumber ("Введите Второе натуральное число : ");

Console.WriteLine();
Console.WriteLine ($"Функция Аккермана для чисел {num1} и {num2} равна {AccermanFunction (num1, num2)}");
