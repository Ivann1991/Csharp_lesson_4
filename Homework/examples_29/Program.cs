// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] myArray = userelement(8);

for (int i = 0; i < 8; i++)
    Console.Write(myArray[i] + " ");
    
//////////////////////////////
int[] userelement(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"введи элемент массива с индексом {i}: ");
        Array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return Array;

}
