//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

Console.Write("Введите размер массива:\t");
int n = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)//создание массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void ReverseArray(int[] array)// переворачивание массива
{
    int size = array.Length;
    int temp;
    for (int i = 0; i < size / 2; i++)
    {
        temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }

    Console.WriteLine($"Перевернутый массив:\t [{string.Join(" ", array)}]");
}

int[] array = CreateArray(n);
Console.WriteLine($"Исходный массив:\t [{string.Join(" ", array)}]");
ReverseArray(array);
