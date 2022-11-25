// // Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Пример: ["hello", "2","world", ":-)"] -> ["2", ":-)"]

//["1234", "1567", "-2", "long word"] -> ["-2"]

//["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

Console.Write("Задайте длину массива: ");
int size = int.Parse(Console.ReadLine()?? "");
string[] array = new string[size];
Console.WriteLine("Введите поочерёдно элементы массива: ");

for (int s = 0; s < array.Length; s++)
{
    array[s] = Console.ReadLine() ?? "";
}

int index = 0;
string[] array2 = new string[size];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[index] = array[i];
        index++;
    }
}

Console.WriteLine();
Print(array2);
