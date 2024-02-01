int[,] matrix = { { 7, 10, 15, 54 }, { 8, 9, 9, 9 }, { 18, 11, 18, 32 } };
int max;
int loc = 0;
int bl = 1;
// Attention
// I have taken into account the case where in one row we can have a few maximum values like in second row of my matrix
for (int i = 0; i < matrix.GetLength(0); i++)
{
    max = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
            loc = j;
        }
    }
    finder(max, loc);
    for (int l = loc + 1; l < matrix.GetLength(1); l++)
    {
        if (matrix[i, l] == max)
        {
            finder(max, l);
        }
    }
    if (bl == 0)
    {
        break;
    }
    else if (i == matrix.GetLength(0) - 1 && bl == 1)
    {
        Console.WriteLine("There is no such a number");
    }
}
void finder(int max, int loc)
{
    int min = matrix[0, loc];
    int loc2 = 0;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        if (matrix[k, loc] < min)
        {
            min = matrix[k, loc];
            loc2 = k;
        }
    }
    if (max == min)
    {
        Console.WriteLine($"That number is {max} and the location is {loc2} {loc}");
        bl = 0;
    }
}
