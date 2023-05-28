int dimensions = int.Parse(Console.ReadLine());

char[,] matrix = new char[dimensions,dimensions];

for (int row = 0; row < dimensions; row++)
{
    char[] charArray = Console.ReadLine().ToCharArray();

    for (int col = 0; col < dimensions; col++)
    {
        matrix[row,col] = charArray[col];
    }
}

int charValue = Console.Read();
char searched = Convert.ToChar(charValue);

for (int row = 0;row < dimensions; row++)
{
    for (int col = 0;col < dimensions; col++)
    {
        if (searched == matrix[row, col])
        {
            Console.WriteLine($"({row}, {col})");
            Environment.Exit(0 );
        }
    }
}
Console.WriteLine($"{searched} does not occur in the matrix");