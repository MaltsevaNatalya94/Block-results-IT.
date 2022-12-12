// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//   выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//    лучше обойтись исключительно массивами.

string[] array = mainArray();

string[] result = resultArray(array, 3);

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] resultArray(string[] input, int n)
{
    string[] output = new string[counter(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int counter(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if (input[i].Length <= n) 
        {
            count++;
        }
    }

    return count;
}

string[] mainArray() 
{
    Console.WriteLine("Введите значения ");

    return Console.ReadLine().Split(" ");
}
