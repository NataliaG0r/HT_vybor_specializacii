// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ".-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("[");
        System.Console.Write(array[i]);
        Console.Write("]");
    }
    System.Console.WriteLine("");
}

int sizeResultArray(string[] array)
{
    int sizeResultArray = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sizeResultArray++;
        }
        
    }
    return sizeResultArray;
}

string[] ResultArray(string[] ArrayIn, int size)
{
    string[] ResultArray = new string[size];

    int index = 0;
    for (int i = 0; i < ArrayIn.Length; i++)
    {
        if (ArrayIn[i].Length <= 3)
        {
            ResultArray[index] = ArrayIn[i];

            index++;
        }
    }
    return ResultArray;
}

string[] MyArray = { "hello", "3", "world", ":-)" };
Console.Write("задан массив:");
PrintArray(MyArray);

Console.WriteLine("массив из строк, длина которых меньше либо равна 3 символа^");

string [] NewArray =ResultArray(MyArray,sizeResultArray(MyArray));
PrintArray (NewArray);

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

string[] MyArray1 = { "1234", "1567", "-2", "computer science"};
Console.Write("задан массив:");
PrintArray(MyArray1);

Console.WriteLine("массив из строк, длина которых меньше либо равна 3 символа^");

string [] NewArray1 =ResultArray(MyArray1,sizeResultArray(MyArray1));
PrintArray (NewArray1);

// ["Russia", "Denmark", "Kazan"] -> []

string[] MyArray2 = {"Russia", "Denmark", "Kazan"};
Console.Write("задан массив:");
PrintArray(MyArray2);

Console.WriteLine("массив из строк, длина которых меньше либо равна 3 символа:");

string [] NewArray2 =ResultArray(MyArray2,sizeResultArray(MyArray2));
PrintArray (NewArray2);