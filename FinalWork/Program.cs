Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

FillArray(array);
Console.WriteLine();
PrintArray(array, 1);

string[] newArray = new string[CountStrings(array)];

FindStringLessThatThree(array);
Console.WriteLine();
PrintArray(newArray, 2);


void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите строку- элемент массива");
        string str = Console.ReadLine();
        array[i] = str;
    }
}

void PrintArray(string[] array, int number)
{
    Console.WriteLine($"Массив {number}");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountStrings(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }
    return count;
}

void FindStringLessThatThree(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
}