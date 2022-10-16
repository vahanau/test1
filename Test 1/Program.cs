using System;

using static System.Console;

Clear();

int FindNewLength(string[] array)
{
    int newLength = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newLength++;
    }
    return newLength;
}

void CreateAndPrintNewArray(string[] oldArray, int newLength)
{
    string[] newArray = new string[newLength];
    int i = 0;

    foreach (string j in oldArray)
    {
        if (j.Length <= 3)
        {
            newArray[i] = j;
            i++;
        }
    }
    PrintArray(newArray);
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] array = { "Ура", "Россия", "Вперед", "Победа", "Сон" };
PrintArray(array);

int newLength = FindNewLength(array);

if (newLength == 0) Console.WriteLine("[]");
else CreateAndPrintNewArray(array, newLength);