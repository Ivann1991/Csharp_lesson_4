// напишите программу, которая выводит массив  из 8 элементов, заполненный нулями и единицами в случайном порядке


int [] Array = GetRandomNumbers(8);

for (int i = 0; i < 8; i++)
    Console.Write(Array [i] + " ");


/////////////////////////////////
int [] GetRandomNumbers(int size)
{
    int [] num = new int [size];

    for (int i = 0; i < size; i++)
    {

        num [i]= new Random().Next(0, 2);
    }
    return num;
}