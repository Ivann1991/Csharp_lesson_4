// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int number1 = usernum("Введи первое число ", "ошибка ввода");
int number2 = usernum("Введи второе число ", "ошибка ввода");
double b = usernumPOW(number1, number2);
Console.Write($"{number1}^{number2} -> {b}");

//////////////////////////////
int usernum(string Message, string errorMessage)
{
    while (true)
    {
        Console.Write(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernum);
        if (isCorrect)
            return usernum;
        Console.WriteLine(errorMessage);
    }
}

double usernumPOW(int number1, int number2)
{
    double a = Math.Pow(number1, number2);
    return a;
 
}
