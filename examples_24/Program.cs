// Напиши программу которая принимает на вход число (А) и выдает сумму чисел от 1 до (А).

Console.Clear();

int usernum = GetNumberFromUser("Введите целое число ", "Ошибка ввода ");
int sum = summa(usernum);
Console.WriteLine(sum);


////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernum);
        if (isCorrect)
            return usernum;
        Console.WriteLine(errorMessage);
    }
}



int summa(int usernum)

{
    int sum = 0;
    for (int a = 1; a <= usernum; a++)
    {
        sum += a;
    }
    return sum;
}