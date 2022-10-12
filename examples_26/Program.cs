// Напишите программу, которая принимает на вход число и выдает количество цифр в числе. 

Console.Clear();

int usernum = UserNumber("Введи целое число ", "Ошибка ввода ");
int CountNumber = CountNum(usernum);
Console.Write(CountNumber);



//////////////////////////////////////
int UserNumber(string Message, string errorMessage)
{
    while (true)
    {
        Console.Write(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect)
            return Math.Abs(num);
        Console.WriteLine(errorMessage);
    }
}

int CountNum(int usernum)
{
    int count = 0;
    if (usernum >= 0 && usernum < 10)
    {
        count = count + 1;
        return count;
    }
    else
    {
        for (int a = 1; a <= usernum; a = a * 10)
        {
            count = count + 1;
        }
        return count;
    }
}
