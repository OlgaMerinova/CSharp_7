//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("введите количество строк: ");
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int [strsCount, columnsCount];
Random rnd = new Random();


for (int i=0; i<strsCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        arr[i,j] = new Random().Next(1, 20);
        Console.Write($"{arr[i, j]} ");
    }
Console.WriteLine();
}
Console.WriteLine("---------------------------");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avg += arr[i, j];
        avg = Math.Round(avg, 1);
    }
    Console.Write($"{ avg / arr.GetLength(0)} ");
}
Console.ReadLine();
