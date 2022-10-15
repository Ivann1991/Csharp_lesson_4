// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int usnum = usernum("Введи целое число ", "ошибка ввода ");
int a = SumNumber(usnum);
Console.Write ($"сумма цифр твоего числа {usnum} это {a}");


/////////////////////////////////////
int usernum(string Message, string errorMessage)
{
    while(true)
    {
        Console.Write(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect)
            return num;
        Console.WriteLine(errorMessage);    
    }
}

int SumNumber (int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}
