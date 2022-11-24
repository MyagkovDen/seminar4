// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);





/////////////////////////////////////////////////////////////////////////////////////////

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
        // collection[index] = new Random().Next(1, 9); // альтернативный вариант определения значений элементов массива
    }
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int index = 0; index < collection.Length; index++)
        Console.Write($"{collection[index]}, ");
    Console.Write("]");
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        else
            Console.WriteLine(errorMessage);
    }
}