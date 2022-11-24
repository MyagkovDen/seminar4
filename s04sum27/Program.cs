// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 782 -> 10
// 9012 -> 12


int numberA = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sum = SumNumerals(numberA);
Console.WriteLine($"{numberA} -> {sum}");




/////////////////////////////////////////////////////////////////////////////////////////

int SumNumerals(int number)
{
    sum = 0;
    if (number < 0)
        number = number * (-1);

    while (number > 0)
    {
        int numeral = number % 10;
        sum = sum + numeral;
        number = number / 10;
    }
    return sum;
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