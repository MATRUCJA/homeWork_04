//Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 10;
int[] array = new int[size];

void CountEven(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
    }

    Console.WriteLine($"Массив: [{string.Join(" ", array)}]\nКоличество четных элементов: {countEven}");
}
CountEven(array);