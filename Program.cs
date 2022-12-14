/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/


void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter the number of the array {i}");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

void NewArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
        Console.Write($"{array[i]} ");
        }
    }
    Console.Write("]");
}

Console.WriteLine("Enter the initial size of the array elements");
int Arr = Convert.ToInt32(Console.ReadLine());
string[] array = new string[Arr];
InputArray(array);
Console.WriteLine();
Console.Write("The resulting array is - ");
NewArray(array);
