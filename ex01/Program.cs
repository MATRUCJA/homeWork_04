/*Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается
при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.*/

string? number;
int sum = 0;

void InputNumber()
{
    do
    {
        number = Console.ReadLine();

        if (number == "q")
        {
            Console.Write($"Ввели q");
            break;
        }
        sum += Convert.ToInt32(number);
        if (sum % 2 == 0)
        {
            Console.Write($"sum= {sum}");
            break;
        }

    } while (true);
}

Console.WriteLine("Введите любое число закончив ввод с помощью q");
InputNumber();



