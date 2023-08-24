int[,] CreateArrayRndInt(int rows, int colum, int min, int max)
{
    int[,] arr = new int[rows,colum];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)// или i < arr.GetLength(0)
    {
        for (int j = 0; j < colum; j++)//или i < arr.GetLength(1)
        {
            arr[i,j] = rnd.Next(min, max+1);
        }

    }
    return arr;
}
void PrintArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
                
                Console.Write($"{arr[i,j],2} ");
                
        }
        Console.WriteLine();
    }
  
} 
Console.WriteLine();

void ArithmeticalAverage(int[,] arr)
{
    double sum =0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum+=Convert.ToDouble(arr[i,j])/Convert.ToDouble(arr.GetLength(0));
        }
        Console.WriteLine($"Среднее арифметическое в столбце №{j+1} ->-{sum}");
        sum = 0;
    }
}

Console.WriteLine("Введите число строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мин предел диапазона чисел");
int minim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите макс предел диапазона чисел");
int maxim = Convert.ToInt32(Console.ReadLine());

int[,] result = CreateArrayRndInt(row,column,minim,maxim);
PrintArray(result);
Console.WriteLine();
ArithmeticalAverage(result);