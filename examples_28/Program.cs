// Напиши программу которая принимает на вход число (N) и выдает произведение чисел от 1 до (N).

Console.Clear();

int usernum = GetNumberFromUser("Введите целое число ", "Ошибка ввода ");
int sum = proiz(usernum);
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



int proiz(int usernum)

{
    int proiz = 1;
    for (int a = 1; a <= usernum; a++)
    {
        proiz *= a;
    }
    return proiz;
}