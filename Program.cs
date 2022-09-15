// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Clear();
// string[] array = new string[4] {"hello", "2", "world", ":-)"};
// string[] array = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array = new string[3] {"Russia", "Denmark", "Kazan"};
string[] arr = new string[array.Length];
void IfSmaller(string[] array, string[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arr[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
Console.WriteLine($"Строки массива с длиной, меньше 3-х символов: ");
IfSmaller(array, arr);
PrintArray(arr);