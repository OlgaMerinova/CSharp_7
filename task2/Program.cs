//Задача 2. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("введите количество строк: ");
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] twoDimArray = new int [strsCount, columnsCount];
Random rnd = new Random();
int N = 17;

for (int i=0; i<strsCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        twoDimArray[i,j] = new Random().Next(1, 20);
        Console.Write($"{twoDimArray[i, j]} ");
    }
Console.WriteLine();
}

for (int i=0; i<strsCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        if (N == twoDimArray[i,j])
        {
            Console.WriteLine("данный элемент есть в массиве");
            break;
        }
        else 
        {
            Console.WriteLine("данного элемента нет в массиве");
        }
    }
}




