/*Console.WriteLine("Give the value of row");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give the value of column");
int m = Convert.ToInt32(Console.ReadLine());

if (n > 0 && n < 9 && m > 0 && m < 9)
{
    for (int i = 1; i < 9; i++)
    {
        for (int j = 1; j < 9; j++)
        {
            if ((Math.Abs(n - i) == 2 && Math.Abs(m - j) == 1) || (Math.Abs(n - i) == 1 && Math.Abs(m - j) == 2))
            {
                Console.Write("1 ");
            }
            else if (n == i && m == j)
            {
                Console.Write("K ");
            }
            else
            {
                Console.Write("0 ");
            }
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("You have mistaken the numbers");
}*/