/* Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GenerateRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for(int i = 0; i < length; i ++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint +1);
    }
    return resultArray;
}
int getSumOfElementsInOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if( i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}
int[] array = GenerateRandomArray(6, 1, 10);
printArray (array);
int SumOfElementsInOddPositions = getSumOfElementsInOddPositions(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumOfElementsInOddPositions}.");

