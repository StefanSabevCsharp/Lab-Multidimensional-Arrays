int numRows = int.Parse(Console.ReadLine());


for (int row = 0; row < numRows; row++)
{
    int number = 1;

    for (int i = 0; i <= row; i++)
    {
        Console.Write(number + " ");
        number = number * (row - i) / (i + 1);
    }

    Console.WriteLine();
}

