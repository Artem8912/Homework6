double[,] CreateArray (int rows,int colum,int max)
{
    double[,] arr = new double[rows,colum];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i,j] =Math.Round(max*rnd.NextDouble(),2);
        }
    }

    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j],10}");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите число строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите макс предел");
int maxim = Convert.ToInt32(Console.ReadLine());

double[,] result = CreateArray(row,column,maxim);
PrintArray(result);