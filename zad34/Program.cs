/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GenerateRandomeArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for(int i = 0; i < length; i ++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint +1);
    }
    return resultArray;
}
int getOfPositiveThreeDigitNumbersInArray(int[] array)
{
    int countOfPositive = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if(array[i] % 2 == 0)
        {
            countOfPositive ++;
        }
    }
    return countOfPositive;
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
int[] array = GenerateRandomeArray(6, 100, 999);
printArray (array);
int countOfPositive = getOfPositiveThreeDigitNumbersInArray(array);
Console.WriteLine($" количество чётных чисел в массиве равно: {countOfPositive}");

