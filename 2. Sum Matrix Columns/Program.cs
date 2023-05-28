int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = numbers[0];
int cols = numbers[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] currentNumbrrs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentNumbrrs[col];
    }
}
for (int col = 0; col < cols; col++)
{
    int sum = 0;
    for (int row = 0; row < rows; row++)
    {
        sum += matrix[row, col];
    }
    Console.WriteLine(sum);
}