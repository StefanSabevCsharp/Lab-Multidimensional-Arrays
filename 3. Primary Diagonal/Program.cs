int dimentions = int.Parse(Console.ReadLine());

int[,] matrix = new int[dimentions,dimentions];

for (int row = 0; row < dimentions; row++)
{
    int[] currentNumbres = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < dimentions; col++)
    {
        matrix[row,col] = currentNumbres[col];
    }

}

int result = 0;

for (int row = 0;row < dimentions; row++)
{
    result += matrix[row, row];
}
Console.WriteLine(result);