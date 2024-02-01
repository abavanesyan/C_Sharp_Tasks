/*Console.WriteLine("Give the value of row");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give the value of column");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        adding(i, j);
    }
    Console.WriteLine();
}

void adding(int i, int j)
{
    Random rnd = new Random();
    int rand_n = rnd.Next(0, n * m * 10);
    int bl = 1;
    foreach (int x in matrix)
    {
        if (x == rand_n)
        {
            bl = 0;
        }
    }
    if (bl == 1)
    {
        matrix[i, j] = rand_n;
        Console.Write($"{matrix[i, j]} ");
    }
    else
    {
        adding(i, j);
    }
}*/