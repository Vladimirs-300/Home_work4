// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] Create(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}
void DisplayArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}
DisplayArray(Create(8));