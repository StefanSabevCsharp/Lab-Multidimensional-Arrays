int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = numbers[0];
int cols = numbers[1];

int[,] matrix = new int[rows, cols];
int result = 0;
for (int row = 0; row < rows; row++)
{
    int[] currentNumbrrs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentNumbrrs[col];
        result += matrix[row, col];
    }
}

int startRow = 0;
int startCol = 0;
int sum = int.MinValue
    ;
for (int row = 0; row < rows - 1; row++)
{
        int currentSum = 0;

    for (int col = 0; col < cols - 1; col++)
    {
        currentSum = matrix[row, col] + matrix[row, col + 1]
            + matrix[row + 1, col] + matrix[row + 1, col + 1];
         
        if (currentSum > sum)
        {
            startRow= row;
            startCol= col;
            sum = currentSum;
        }
    }
}

for (int row = startRow; row <= startRow + 1; row++)
{
  

    for (int col = startCol; col <= startCol + 1; col++)
    {
        Console.Write(matrix[row,col] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(sum);