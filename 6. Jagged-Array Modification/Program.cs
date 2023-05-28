int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).ToArray();
    for (int j = 0; j < numbers.Length; j++)
    {
        if (jaggedArray[row] == null)
        {
            jaggedArray[row] = new int[numbers.Length];
        }
        jaggedArray[row][j] = numbers[j];
    }
}

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "END")
{
    if (command[0] == "Add")
    {
        int rowIndex = int.Parse(command[1]);
        int colIndex = int.Parse(command[2]);

        if (isValidIndexes(rowIndex,colIndex,jaggedArray))
        {
            int numberToAdd = int.Parse(command[3]);
            jaggedArray[rowIndex][colIndex] += numberToAdd;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
    else if (command[0] == "Subtract")
    {
        int rowIndex = int.Parse(command[1]);
        int colIndex = int.Parse(command[2]);

        if (isValidIndexes(rowIndex, colIndex, jaggedArray))
        {
            int numberToSubstract = int.Parse(command[3]);
            jaggedArray[rowIndex][colIndex] -= numberToSubstract;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
    


    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write($"{jaggedArray[row][col]} ");
    }
    Console.WriteLine();
}

bool isValidIndexes(int rowIndex,int colIndex,int[][] jaggedArray)
{
    //if (jaggedArray[rowIndex][colIndex] > int.MinValue ) 
    //{ 
    //    return true; 
    //}
    //if (jaggedArray[rowIndex] != null && colIndex < jaggedArray[rowIndex].Length && colIndex >= 0)
    //{
    //    return true;
    //}
    if (rowIndex >= 0 && rowIndex < jaggedArray.GetLength(0))
    {
        if (colIndex >= 0 && colIndex < jaggedArray[rowIndex].Length)
        {
            return true;
        }
    }

    return false;
}