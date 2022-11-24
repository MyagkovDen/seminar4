// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = GetNumberFromUser("Введите число A: ", "Ошибка ввода!");
int numberB = GetNumberFromUser("Введите число B: ", "Ошибка ввода!");
int result = RaiseToPower(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {result}");



////////////////////////////////////////////////////////////////////////////////////////////////

int RaiseToPower(int number, int power)
{
    int res = 1;
    for (int i = 0; i < power; i++)
    {
        res = res * number;
    }
    return res;
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