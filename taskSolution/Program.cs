// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreatArray() 
{
    Console.Write("Введите элементы массива через пробел: ");
    return Console.ReadLine().Split(" ");
}

int FindSizeArray (string[] array, int sizeElement)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeElement) size++;
    }
    return size;
}

string[] CreatNewArray(string[] array, int amountSimbol)
{
    string[] arrayNew = new string[FindSizeArray (array, amountSimbol)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= amountSimbol)
        {
        arrayNew[j] = array[i];
        j++;
        }
    }
    return arrayNew;
}

string [] arrayStart = CreatArray();
Console.WriteLine($"Начальный массив: [{string.Join (", ", arrayStart)}]");
string [] arrayFinal = CreatNewArray(arrayStart, 3);
Console.WriteLine($"Новый массив: [{string.Join (", ", arrayFinal)}]");