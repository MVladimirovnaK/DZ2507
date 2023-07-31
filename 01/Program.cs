void Task47()
// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами, округлёнными до одного знака.
{
    
    int rows = 4;
    int columns = 7;
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(-100, 100) + rnd.NextDouble();
            matrix[i,j] = Math.Round(matrix[i,j], 1);
        }
        
    }
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void Task50()
// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
{
    int rows = 4;
    int columns = 7;
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(-100,100);
        }
    }
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Введите номер строки: ");
    int m=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int n=Convert.ToInt32(Console.ReadLine());
    if(m<matrix.GetLength(0) && n<matrix.GetLength(1))
    {
        Console.WriteLine($"В строке {m} в столбце {n} указанного массива находится элемент {matrix[m,n]}.");
    }
    else
    {
        Console.WriteLine($"Элемента с индексами [{m},{n}] не существует");
    }
}
void Task52()
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
{
    int rows = 4;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(1,10);
        }
    }
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    for(int j=0;j<columns; j++)
    {
        double sum=0;
        for(int i=0; i<rows; i++)
        {
            sum=sum+matrix[i,j];
        }
        double average=sum/rows;
        average = Math.Round(average,2);
        Console.WriteLine($"Среднее арифметическое всех значений в {j} столбце = {average}.");
    }
}
Task52();