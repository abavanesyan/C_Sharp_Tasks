/*Console.WriteLine("Give the value of row");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give the value of column");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[8, 8];
List<int[]> loc = new List<int[]>(); // This list is for gathering the places where the knight can go
void knight(int n, int m)
{
    loc.Clear();
    for (int i = 1; i < 9; i++)
    {
        for (int j = 1; j < 9; j++)
        {
            if ((Math.Abs(n - i) == 2 && Math.Abs(m - j) == 1) || (Math.Abs(n - i) == 1 && Math.Abs(m - j) == 2))
            {
                if (arr[i - 1, j - 1] != 9)
                {
                    arr[i - 1, j - 1] = 1;
                    loc.Add([i, j]);
                }
            }
            else if (n == i && m == j)
            {
                arr[i - 1, j - 1] = 9;
            }
            else
            {
                if (arr[i - 1, j - 1] != 9)
                {
                    arr[i - 1, j - 1] = 0;
                }
            }
        }
    }
    for (int k = 0; k < 8; k++)
    {
        for (int l = 0; l < 8; l++)
        {
            if (arr[k, l] == 9)
            {
                Console.Write("K ");
            }
            else if (arr[k, l] == 1)
            {
                Console.Write("1 ");
            }
            else
            {
                Console.Write("0 ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("Do you want to continue (y or n)");
    string ans = Console.ReadLine();

    if (ans == "y")
    {
        if (loc.Count != 0)
        {
            Random rnd = new Random();
            int r1 = rnd.Next(0, loc.Count - 1);
            knight(loc[r1][0], loc[r1][1]);
        }
        else
        {
            Console.WriteLine("There is no place left");
        }
    }
}
if (n > 0 && n < 9 && m > 0 && m < 9)
{
    knight(n, m);
}
else
{
    Console.WriteLine("You have mistaken the numbers");
}*/